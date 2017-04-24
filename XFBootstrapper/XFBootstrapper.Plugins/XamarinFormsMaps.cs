using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFBootstrapper.Extensibility;

namespace XFBootstrapper.Plugins
{
    /// <summary>
    /// Cross Platform implementation of native maps for use with Xamarin.Forms projects.
    /// </summary>
    /// <seealso cref="XFBootstrapper.Extensibility.IPlugin" />
    public class XamarinFormsMaps : IPlugin
    {
        public string Authors => "Zumberge Enterprises";

        public string Copyright => "Zumberge Enterprises 2017";

        public string Description => "Cross Platform implementation of native maps for use with Xamarin.Forms projects";

        public ExtensionPoint ExtensionPoint => ExtensionPoint.MobileServices;

        public string Id => "com.zesoft.plugin.xamarinformsmaps";

        public bool RequireLicenseAcceptance => false;

        public string LicensingText => String.Empty;

        public string Name => "Maps";

        public string Owners => "Zumberge Enterprises";

        public string ReleaseNotes => "Initial offering of the Map plugin.";

        public string Version => new VersionNumber(1, 0, 0).ToString();

        public List<ProjectType> RequiredProjectTypes => new List<ProjectType>
        {
            ProjectType.Mobile
        };

        public List<ProjectType> IncompatibleProjectTypes => new List<ProjectType> { };

        public List<ProjectPlatform> RequiredProjectPlatforms => new List<ProjectPlatform> { };

        public List<ProjectPlatform> IncompatibleProjectPlatforms => new List<ProjectPlatform> { };

        public Uri SupportUrl => new Uri("http://chriszumberge.com/");

        public DateTime PublishDate { get; set; }

        public void Configure(ref IProjectContext projectContext)
        {
            
        }
    }
}
