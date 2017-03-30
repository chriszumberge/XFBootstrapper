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
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int value { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public List<PluginViewModel> features { get; set; } = new List<PluginViewModel>();

        public FeatureViewModel(ExtensionPoint extPoint)
        {
            name = extPoint.Name;
            value = extPoint.Value;
            icon = extPoint.Icon;
        }
    }
}