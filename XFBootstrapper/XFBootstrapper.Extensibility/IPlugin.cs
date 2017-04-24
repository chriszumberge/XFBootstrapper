using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBootstrapper.Extensibility
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        string Id { get; }
        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        string Version { get; }
        /// <summary>
        /// Gets the authors.
        /// </summary>
        /// <value>
        /// The authors.
        /// </value>
        string Authors { get; }
        /// <summary>
        /// Gets the owners.
        /// </summary>
        /// <value>
        /// The owners.
        /// </value>
        string Owners { get; }
        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        string Description { get; }
        /// <summary>
        /// Gets the copyright.
        /// </summary>
        /// <value>
        /// The copyright.
        /// </value>
        string Copyright { get; }
        /// <summary>
        /// Gets the release notes.
        /// </summary>
        /// <value>
        /// The release notes.
        /// </value>
        string ReleaseNotes { get; }
        /// <summary>
        /// Gets a value indicating whether [require license acceptance].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [require license acceptance]; otherwise, <c>false</c>.
        /// </value>
        bool RequireLicenseAcceptance { get; }
        /// <summary>
        /// Gets the licensing text.
        /// </summary>
        /// <value>
        /// The licensing text.
        /// </value>
        string LicensingText { get; }
        /// <summary>
        /// Gets the support URL.
        /// </summary>
        /// <value>
        /// The support URL.
        /// </value>
        Uri SupportUrl { get; }
        /// <summary>
        /// Gets or sets the publish date.
        /// If not defined, will default to using the assembly build date and time.
        /// </summary>
        /// <value>
        /// The publish date.
        /// </value>
        DateTime PublishDate { get; set; }
        /// <summary>
        /// Gets the extension point.
        /// </summary>
        /// <value>
        /// The extension point.
        /// </value>
        ExtensionPoint ExtensionPoint { get; }
        /// <summary>
        /// Gets the required project types.
        /// </summary>
        /// <value>
        /// The required project types.
        /// </value>
        List<ProjectType> RequiredProjectTypes { get; }
        /// <summary>
        /// Gets the forbidden project types.
        /// </summary>
        /// <value>
        /// The forbidden project types.
        /// </value>
        List<ProjectType> IncompatibleProjectTypes { get; }
        /// <summary>
        /// Gets the required project platforms.
        /// </summary>
        /// <value>
        /// The required project platforms.
        /// </value>
        List<ProjectPlatform> RequiredProjectPlatforms { get; }
        /// <summary>
        /// Gets the forbidden project platforms.
        /// </summary>
        /// <value>
        /// The forbidden project platforms.
        /// </value>
        List<ProjectPlatform> IncompatibleProjectPlatforms { get; }

        /// <summary>
        /// Allows the plugin to configure the specified project context.
        /// </summary>
        /// <param name="projectContext">The project context.</param>
        void Configure(ref IProjectContext projectContext);
    }
}
