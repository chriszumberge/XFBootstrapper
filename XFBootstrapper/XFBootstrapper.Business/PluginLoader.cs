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
    /// <summary>
    /// 
    /// </summary>
    public sealed class PluginLoader
    {
        //Dictionary<string, IPlugin> mPlugins { get; set; }
        //public Dictionary<string, IPlugin> Plugins => mPlugins;
        List<IPlugin> mPlugins { get; set; } = new List<IPlugin>();
        /// <summary>
        /// Gets the plugins.
        /// </summary>
        /// <value>
        /// The plugins.
        /// </value>
        public List<IPlugin> Plugins => mPlugins;

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginLoader"/> class.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
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
                //ICollection<Type> pluginTypes = new List<Type>();
                foreach (Assembly assembly in assemblies)
                {
                    DateTime assemblyLinkLocalTime = assembly.GetLinkerTime();
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
                                //pluginTypes.Add(type);
                                IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                                plugin.PublishDate = assemblyLinkLocalTime;

                                mPlugins.Add(plugin);
                            }
                        }
                    }
                }

                // Create instances using reflection
                //ICollection<IPlugin> plugins = new List<IPlugin>(pluginTypes.Count);
                //foreach (Type type in pluginTypes)
                //{
                //    IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                //    //mPlugins.Add(plugin.Name, plugin);
                //    mPlugins.Add(plugin);
                //}
            }
            else
            {
                throw new Exception($"Plugin Installation Path '{Constants.PluginInstallationPath}' does not exist.");
            }
        }
    }

    internal static class AssemblyExtensions
    {
        internal static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null)
        {
            var filePath = assembly.Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;

            var buffer = new byte[2048];

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                stream.Read(buffer, 0, 2048);

            var offset = BitConverter.ToInt32(buffer, c_PeHeaderOffset);
            var secondsSince1970 = BitConverter.ToInt32(buffer, offset + c_LinkerTimestampOffset);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var linkTimeUtc = epoch.AddSeconds(secondsSince1970);

            var tz = target ?? TimeZoneInfo.Local;
            var localTime = TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, tz);

            return localTime;
        }
    }
}
