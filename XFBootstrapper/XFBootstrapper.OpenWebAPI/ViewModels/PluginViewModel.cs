using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using XFBootstrapper.Extensibility;

namespace XFBootstrapper.OpenWebAPI.ViewModels
{
    /// <summary>
    /// View Model for binding Plugins to the Web App
    /// </summary>
    [DataContract]
    public class PluginViewModel
    {
        private IPlugin plugin;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string name { get; protected set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
        public string id { get; protected set; }
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        [DataMember]
        public string version { get; protected set; }
        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        /// <value>
        /// The authors.
        /// </value>
        [DataMember]
        public string authors { get; protected set; }
        /// <summary>
        /// Gets or sets the owners.
        /// </summary>
        /// <value>
        /// The owners.
        /// </value>
        [DataMember]
        public string owners { get; protected set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember]
        public string description { get; protected set; }
        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        /// <value>
        /// The copyright.
        /// </value>
        [DataMember]
        public string copyright { get; protected set; }
        /// <summary>
        /// Gets or sets the release notes.
        /// </summary>
        /// <value>
        /// The release notes.
        /// </value>
        [DataMember]
        public string release_notes { get; protected set; }
        /// <summary>
        /// Gets or sets a value indicating whether [require license acceptance].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [require license acceptance]; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool require_license_acceptance { get; protected set; }
        /// <summary>
        /// Gets or sets the licensing text.
        /// </summary>
        /// <value>
        /// The licensing text.
        /// </value>
        [DataMember]
        public string licensing_text { get; protected set; }
        /// <summary>
        /// Gets or sets the publish date.
        /// </summary>
        /// <value>
        /// The publish date.
        /// </value>
        [DataMember]
        public string publish_date { get; protected set; }
        /// <summary>
        /// Gets or sets the support URL.
        /// </summary>
        /// <value>
        /// The support URL.
        /// </value>
        [DataMember]
        public string support_url { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginViewModel"/> class.
        /// </summary>
        /// <param name="plugin">The plugin to convert to an instance of the view model.</param>
        public PluginViewModel(IPlugin plugin)
        {
            this.plugin = plugin;

            this.name = plugin.Name;
            this.id = plugin.Id;
            this.version = plugin.Version.ToString();
            this.authors = plugin.Authors;
            this.owners = plugin.Owners;
            this.description = plugin.Description;
            this.copyright = plugin.Copyright;
            this.release_notes = plugin.ReleaseNotes;
            this.require_license_acceptance = plugin.RequireLicenseAcceptance;
            this.licensing_text = plugin.LicensingText;
            this.publish_date = plugin.PublishDate.ToString();
            this.support_url = plugin.SupportUrl.ToString();
        }
    }
}