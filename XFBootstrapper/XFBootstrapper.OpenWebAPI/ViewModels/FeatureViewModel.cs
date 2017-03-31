using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using XFBootstrapper.Extensibility;

namespace XFBootstrapper.OpenWebAPI.ViewModels
{
    [DataContract]
    public class FeatureViewModel
    {
        ExtensionPoint extensionPoint;

        [DataMember]
        public string name { get; protected set; }
        [DataMember]
        public int value { get; protected set; }
        [DataMember]
        public string icon { get; protected set; }

        [DataMember]
        public List<PluginViewModel> features { get; set; } = new List<PluginViewModel>();

        public FeatureViewModel(ExtensionPoint extPoint)
        {
            extensionPoint = extPoint;
            name = extensionPoint.Name;
            value = extensionPoint.Value;
            icon = extensionPoint.Icon;
        }
    }
}