using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.AspNetCore.WebHooks
{
    [PublicAPI]
    public sealed class MenuId : Enumeration
    {
        private MenuId(string value) : base(value) { }

        [PublicAPI]
        public static class Global
        {
            public static readonly MenuId Sections = new MenuId("Global.Sections");
            public static readonly MenuId ProfileMenu = new MenuId("Global.Profile");
            public static readonly MenuId Add = new MenuId("Global.Add");
        }

        [PublicAPI]
        public static class Project
        {
            public static readonly MenuId ProjectToolsMenu = new MenuId("Project.Tools");
            public static readonly MenuId ProjectSettingsMenu = new MenuId("Project.Settings");
        }

        [PublicAPI]
        public static class Repository
        {
            public static readonly MenuId Menu = new MenuId("Repository.Settings");
        }

        [PublicAPI]
        public static class Manage
        {
            public static readonly MenuId Integrations = new MenuId("Sidebar.Administration.Integrations");
            public static readonly MenuId Extensions = new MenuId("Sidebar.Administration.Extensions");
            public static readonly MenuId Organization = new MenuId("Sidebar.Administration.Organization");
            public static readonly MenuId Access = new MenuId("Sidebar.Administration.Access");
            public static readonly MenuId Customization = new MenuId("Sidebar.Administration.Customization");
            public static readonly MenuId Debug = new MenuId("Sidebar.Administration.Debug");
        }

        [PublicAPI]
        public static class Profile
        {
            public static readonly MenuId SidebarPersonal = new MenuId("Sidebar.Profile.Personal");
            public static readonly MenuId SidebarPersonalMy = new MenuId("Sidebar.Profile.Personal.My");
            public static readonly MenuId SidebarSchedule = new MenuId("Sidebar.Profile.Schedule");
            public static readonly MenuId SidebarWorkspace = new MenuId("Sidebar.Profile.Workspace");
            public static readonly MenuId SidebarSecurity = new MenuId("Sidebar.Profile.Security");
        }

        [PublicAPI]
        public static class Location
        {
            public static readonly MenuId Sidebar = new MenuId("Sidebar.Location");
        }

        [PublicAPI]
        public static class Team
        {
            public static readonly MenuId Sidebar = new MenuId("Sidebar.Team");
        }

        [PublicAPI]
        public static class Channel
        {
            public static readonly MenuId Attachment = new MenuId("Channel.Attachment");
            public static readonly MenuId Message = new MenuId("Channel.Message");
        }
    }
}