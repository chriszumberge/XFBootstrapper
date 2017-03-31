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
        /// Gets the extension point.
        /// </summary>
        /// <value>
        /// The extension point.
        /// </value>
        ExtensionPoint ExtensionPoint { get; }

        /// <summary>
        /// Configures the specified project context.
        /// </summary>
        /// <param name="projectContext">The project context.</param>
        void Configure(ref IProjectContext projectContext);
    }
}
