using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XFBootstrapper.Extensibility;

namespace XFBootstrapper.Business
{
    public sealed class PluginLoader
    {
        //Dictionary<string, IPlugin> mPlugins { get; set; }
        //public Dictionary<string, IPlugin> Plugins => mPlugins;
        List<IPlugin> mPlugins { get; set; } = new List<IPlugin>();
        public List<IPlugin> Plugins => mPlugins;

        public PluginLoader()
        {
            // Get all the dlls in the plugin installation path
            string[] dllFileNames = null;
            if (Directory.Exists(Constants.PluginInstallationPath))
            {
                dllFileNames = Directory.GetFiles(Constants.PluginInstallationPath, "*.dll");

                // Load the assemblies using reflection
                ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
                foreach (string dllFile in dllFileNames)
                {
                    AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                    Assembly assembly = Assembly.Load(an);
                    assemblies.Add(assembly);
                }

                // Search for types that implement IPlugin
                Type pluginType = typeof(IPlugin);
                ICollection<Type> pluginTypes = new List<Type>();
                foreach (Assembly assembly in assemblies)
                {
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.IsInterface || type.IsAbstract)
                        {
                            continue;
                        }
                        else
                        {
                            if (type.GetInterface(pluginType.FullName) != null)
                            {
                                pluginTypes.Add(type);
                            }
                        }
                    }
                }

                // Create instances using reflection
                ICollection<IPlugin> plugins = new List<IPlugin>(pluginTypes.Count);
                foreach (Type type in pluginTypes)
                {
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                    //mPlugins.Add(plugin.Name, plugin);
                    mPlugins.Add(plugin);
                }
            }
            else
            {
                throw new Exception($"Plugin Installation Path '{Constants.PluginInstallationPath}' does not exist.");
            }
        }
    }
}
