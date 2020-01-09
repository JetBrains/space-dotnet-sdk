using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SpaceDotNet.Common.Types
{
    public abstract class Enumeration : IComparable
    {
        public string Value { get; private set; }

        protected Enumeration(string value)
        {
            Value = value;
        }

        public override string ToString() => Value;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }
        
        public static T? FromValue<T>(string value) where T : Enumeration, new()
        {
            var matchingItem = GetAll<T>().FirstOrDefault(it => it.Value == value);
            return matchingItem;
        }
        
        public static Enumeration FromValue(Type enumerationType, string value)
        {
            var fields = enumerationType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            
            var matchingItem = fields
                .Select(f => f.GetValue(null))
                .Cast<Enumeration>()
                .FirstOrDefault(it => it.Value == value);
            return matchingItem;
        }

        public override bool Equals(object? obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
            {
                return false;
            }

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(Value);
        }

        public static bool operator ==(Enumeration? left, Enumeration? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Enumeration? left, Enumeration? right)
        {
            return !Equals(left, right);
        }

        public int CompareTo(object? other) => string.Compare(Value, ((Enumeration)other).Value, StringComparison.OrdinalIgnoreCase);
    }
}