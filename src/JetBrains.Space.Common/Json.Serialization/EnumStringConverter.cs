/*
 * MIT License
 * 
 * Copyright (c) 2020 Macross Software
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 * Original sources:
 * https://github.com/Macross-Software/core/blob/develop/ClassLibraries/Macross.Json.Extensions/Code/System.Text.Json.Serialization/JsonStringEnumMemberConverter.cs
 * https://github.com/Macross-Software/core/blob/develop/ClassLibraries/Macross.Json.Extensions/Code/System.Text.Json.Serialization/JsonStringEnumMemberConverter%7BT%7D.cs
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JetBrains.Space.Common.Json.Serialization
{
	/// <summary>
	/// A <see cref="JsonConverterFactory"/> to convert enums to and from strings, respecting <see cref="EnumMemberAttribute"/> decorations. Supports nullable enums.
	/// </summary>
	public class EnumStringConverter : JsonConverterFactory
	{
		private readonly JsonNamingPolicy? _namingPolicy;
		private readonly bool _allowIntegerValues;

		/// <summary>
		/// Initializes a new instance of the <see cref="EnumStringConverter"/> class.
		/// </summary>
		public EnumStringConverter()
			: this(namingPolicy: null, allowIntegerValues: true)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EnumStringConverter"/> class.
		/// </summary>
		/// <param name="namingPolicy">Optional naming policy for writing enum values.</param>
		/// <param name="allowIntegerValues">True to allow undefined enum values. When true, if an enum value isn't defined it will output as a number rather than a string.</param>
		public EnumStringConverter(JsonNamingPolicy? namingPolicy = null, bool allowIntegerValues = true)
		{
			_namingPolicy = namingPolicy;
			_allowIntegerValues = allowIntegerValues;
		}

		/// <inheritdoc/>
		public override bool CanConvert(Type typeToConvert)
		{
			// Don't perform a typeToConvert == null check for performance. Trust our callers will be nice.
			return typeToConvert.IsEnum
			       || (typeToConvert.IsGenericType && TestNullableEnum(typeToConvert).IsNullableEnum);
		}

		/// <inheritdoc/>
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			var (isNullableEnum, underlyingType) = TestNullableEnum(typeToConvert);

			return (JsonConverter)Activator.CreateInstance(
				typeof(EnumStringConverter<>).MakeGenericType(typeToConvert),
				BindingFlags.Instance | BindingFlags.Public,
				binder: null,
				args: new object?[] { _namingPolicy, _allowIntegerValues, isNullableEnum ? underlyingType : null },
				culture: null)!;
		}

		private static (bool IsNullableEnum, Type? UnderlyingType) TestNullableEnum(Type typeToConvert)
		{
			var underlyingType = Nullable.GetUnderlyingType(typeToConvert);

			return (underlyingType?.IsEnum ?? false, underlyingType);
		}
	}
	
	internal class EnumStringConverter<T> : JsonConverter<T>
	{
		private const BindingFlags EnumBindings = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;

		private class EnumInfo
		{
			public string Name { get; }
			public Enum EnumValue { get; }
			public ulong RawValue { get; }

			public EnumInfo(string name, Enum enumValue, ulong rawValue)
			{
				Name = name;
				EnumValue = enumValue;
				RawValue = rawValue;
			}
		}

		private readonly bool _allowIntegerValues;
		private readonly Type _enumType;
		private readonly TypeCode _enumTypeCode;
		private readonly bool _isFlags;
		private readonly Dictionary<ulong, EnumInfo> _rawToTransformed;
		private readonly Dictionary<string, EnumInfo> _transformedToRaw;

		public EnumStringConverter(JsonNamingPolicy? namingPolicy, bool allowIntegerValues, Type? underlyingType)
		{
			_allowIntegerValues = allowIntegerValues;
			_enumType = underlyingType ?? typeof(T);
			_enumTypeCode = Type.GetTypeCode(_enumType);
			_isFlags = _enumType.IsDefined(typeof(FlagsAttribute), true);

			var builtInNames = _enumType.GetEnumNames();
			var builtInValues = _enumType.GetEnumValues();

			_rawToTransformed = new Dictionary<ulong, EnumInfo>();
			_transformedToRaw = new Dictionary<string, EnumInfo>();

			for (var i = 0; i < builtInNames.Length; i++)
			{
				var enumValue = (Enum?)builtInValues.GetValue(i);
				if (enumValue == null) continue;

				var rawValue = GetEnumValue(enumValue);

				var name = builtInNames[i];
				var field = _enumType.GetField(name, EnumBindings)!;
				var enumMemberAttribute = field.GetCustomAttribute<EnumMemberAttribute>(true);
				var transformedName = enumMemberAttribute?.Value ?? namingPolicy?.ConvertName(name) ?? name;

				_rawToTransformed[rawValue] = new EnumInfo(transformedName, enumValue, rawValue);
				_transformedToRaw[transformedName] = new EnumInfo(name, enumValue, rawValue);
			}
		}

		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var token = reader.TokenType;

			if (token == JsonTokenType.String)
			{
				var enumString = reader.GetString();

				// Case sensitive search attempted first.
				if (enumString != null && _transformedToRaw.TryGetValue(enumString, out var enumInfo))
				{
					return (T)Enum.ToObject(_enumType, enumInfo.RawValue);
				}

				if (enumString != null && _isFlags)
				{
					ulong calculatedValue = 0;
					var flagValues = enumString.Split(", ");
					
					foreach (var flagValue in flagValues)
					{
						// Case sensitive search attempted first.
						if (_transformedToRaw.TryGetValue(flagValue, out enumInfo))
						{
							calculatedValue |= enumInfo.RawValue;
						}
						else
						{
							// Case insensitive search attempted second.
							var matched = false;
							foreach (var (enumKey, enumValue) in _transformedToRaw)
							{
								if (string.Equals(enumKey, flagValue, StringComparison.OrdinalIgnoreCase))
								{
									calculatedValue |= enumValue.RawValue;
									matched = true;
									break;
								}
							}

							if (!matched)
							{
								throw new JsonException($"The JSON value '{_enumType}' could not be converted to {flagValue}.");
							}
						}
					}

					return (T)Enum.ToObject(_enumType, calculatedValue);
				}

				// Case insensitive search attempted second.
				foreach (var (enumKey, enumValue) in _transformedToRaw)
				{
					if (string.Equals(enumKey, enumString, StringComparison.OrdinalIgnoreCase))
					{
						return (T)Enum.ToObject(_enumType, enumValue.RawValue);
					}
				}

				throw new JsonException($"The JSON value '{_enumType}' could not be converted to {enumString}.");
			}

			if (token != JsonTokenType.Number || !_allowIntegerValues)
			{
				throw new JsonException($"The JSON value could not be converted to {_enumType}.");
			}

			switch (_enumTypeCode)
			{
				case TypeCode.Int32:
					if (reader.TryGetInt32(out var int32))
					{
						return (T)Enum.ToObject(_enumType, int32);
					}
					break;
				case TypeCode.Int64:
					if (reader.TryGetInt64(out var int64))
					{
						return (T)Enum.ToObject(_enumType, int64);
					}
					break;
				case TypeCode.Int16:
					if (reader.TryGetInt16(out var int16))
					{
						return (T)Enum.ToObject(_enumType, int16);
					}
					break;
				case TypeCode.Byte:
					if (reader.TryGetByte(out var ubyte8))
					{
						return (T)Enum.ToObject(_enumType, ubyte8);
					}
					break;
				case TypeCode.UInt32:
					if (reader.TryGetUInt32(out var uint32))
					{
						return (T)Enum.ToObject(_enumType, uint32);
					}
					break;
				case TypeCode.UInt64:
					if (reader.TryGetUInt64(out var uint64))
					{
						return (T)Enum.ToObject(_enumType, uint64);
					}
					break;
				case TypeCode.UInt16:
					if (reader.TryGetUInt16(out var uint16))
					{
						return (T)Enum.ToObject(_enumType, uint16);
					}
					break;
				case TypeCode.SByte:
					if (reader.TryGetSByte(out var byte8))
					{
						return (T)Enum.ToObject(_enumType, byte8);
					}
					break;
			}

			throw new JsonException($"The JSON value could not be converted to {_enumType}.");
		}

		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			// Note: There is no check for value == null because Json serializer won't call the converter in that case.
			var rawValue = GetEnumValue(value!);

			if (_rawToTransformed.TryGetValue(rawValue, out var enumInfo))
			{
				writer.WriteStringValue(enumInfo.Name);
				return;
			}

			if (_isFlags)
			{
				ulong calculatedValue = 0;

				var builder = new StringBuilder();
				foreach (var enumItem in _rawToTransformed)
				{
					enumInfo = enumItem.Value;
					if (!(value as Enum)!.HasFlag(enumInfo.EnumValue)
						|| enumInfo.RawValue == 0) // Definitions with 'None' should hit the cache case.
					{
						continue;
					}

					// Track the value to make sure all bits are represented.
					calculatedValue |= enumInfo.RawValue;

					if (builder.Length > 0)
					{
						builder.Append(", ");
					}

					builder.Append(enumInfo.Name);
				}
				if (calculatedValue == rawValue)
				{
					writer.WriteStringValue(builder.ToString());
					return;
				}
			}

			if (!_allowIntegerValues)
			{
				throw new JsonException(
					$"Enum type {_enumType} does not have a mapping for integer value '{rawValue.ToString(CultureInfo.CurrentCulture)}'.");
			}

			switch (_enumTypeCode)
			{
				case TypeCode.Int32:
					writer.WriteNumberValue((int)rawValue);
					break;
				case TypeCode.Int64:
					writer.WriteNumberValue((long)rawValue);
					break;
				case TypeCode.Int16:
					writer.WriteNumberValue((short)rawValue);
					break;
				case TypeCode.Byte:
					writer.WriteNumberValue((byte)rawValue);
					break;
				case TypeCode.UInt32:
					writer.WriteNumberValue((uint)rawValue);
					break;
				case TypeCode.UInt64:
					writer.WriteNumberValue(rawValue);
					break;
				case TypeCode.UInt16:
					writer.WriteNumberValue((ushort)rawValue);
					break;
				case TypeCode.SByte:
					writer.WriteNumberValue((sbyte)rawValue);
					break;
				default:
					throw new JsonException(); // GetEnumValue should have already thrown.
			}
		}

		private ulong GetEnumValue(object value)
		{
			return _enumTypeCode switch
			{
				TypeCode.Int32 => (ulong)(int)value,
				TypeCode.Int64 => (ulong)(long)value,
				TypeCode.Int16 => (ulong)(short)value,
				TypeCode.Byte => (byte)value,
				TypeCode.UInt32 => (uint)value,
				TypeCode.UInt64 => (ulong)value,
				TypeCode.UInt16 => (ushort)value,
				TypeCode.SByte => (ulong)(sbyte)value,
				_ => throw new NotSupportedException($"Enum '{value}' of {_enumTypeCode} type is not supported.")
			};
		}
	}
}