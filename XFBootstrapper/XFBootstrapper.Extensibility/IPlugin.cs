using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBootstrapper.Extensibility
{
    public interface IPlugin
    {
        string Name { get; }
        string Id { get; }
        string Version { get; }
        string Authors { get; }
        string Owners { get; }
        string Description { get; }
        string Copyright { get; }
        string ReleaseNotes { get; }

        bool RequireLicenseAcceptance { get; }
        string Licensing { get; }

        ExtensionPoint ExtensionPoint { get; }
    }
}
