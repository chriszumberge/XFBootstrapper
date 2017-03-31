using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using XFBootstrapper.Extensibility;

namespace XFBootstrapper.OpenWebAPI.ViewModels
{
    [DataContract]
    public class PluginViewModel
    {
        private IPlugin plugin;

        [DataMember]
        public string name { get; protected set; }
        [DataMember]
        public string id { get; protected set; }
        [DataMember]
        public string version { get; protected set; }
        [DataMember]
        public string authors { get; protected set; }
        [DataMember]
        public string owners { get; protected set; }
        [DataMember]
        public string description { get; protected set; }
        [DataMember]
        public string copyright { get; protected set; }
        [DataMember]
        public string release_notes { get; protected set; }
        [DataMember]
        public bool require_license_acceptance { get; protected set; }
        [DataMember]
        public string licensing_text { get; protected set; }

        public PluginViewModel(IPlugin plugin)
        {
            this.plugin = plugin;

            this.name = plugin.Name;
            this.id = plugin.Id;
            this.version = plugin.Version;
            this.authors = plugin.Authors;
            this.owners = plugin.Owners;
            this.description = plugin.Description;
            this.copyright = plugin.Copyright;
            this.release_notes = plugin.ReleaseNotes;
            this.require_license_acceptance = plugin.RequireLicenseAcceptance;
            this.licensing_text = plugin.LicensingText;
        }
    }
}