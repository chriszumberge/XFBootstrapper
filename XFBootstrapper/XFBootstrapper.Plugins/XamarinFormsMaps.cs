using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFBootstrapper.Extensibility;

namespace XFBootstrapper.Plugins
{
    public class XamarinFormsMaps : IPlugin
    {
        public string Authors
        {
            get
            {
                return "Zumberge Enterprises";
            }
        }

        public string Copyright
        {
            get
            {
                return "Zumberge Enterprises 2017";
            }
        }

        public string Description
        {
            get
            {
                return "Cross Platform implementation of native maps for use with Xamarin.Forms projects";
            }
        }

        public ExtensionPoint ExtensionPoint
        {
            get
            {
                return ExtensionPoint.MobileServices;
            }
        }

        public string Id
        {
            get
            {
                return "com.zesoft.plugin.xamarinformsmaps";
            }
        }

        public string LicensingText
        {
            get
            {
                return String.Empty;
            }
        }

        public string Name
        {
            get
            {
                return "Maps";
            }
        }

        public string Owners
        {
            get
            {
                return "Zumberge Enterprises";
            }
        }

        public string ReleaseNotes
        {
            get
            {
                return "Initial offering of the Map plugin.";
            }
        }

        public bool RequireLicenseAcceptance
        {
            get
            {
                return false;
            }
        }

        public string Version
        {
            get
            {
                return "1.0.0.0";
            }
        }
    }
}
