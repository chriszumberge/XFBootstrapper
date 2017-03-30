using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using XFBootstrapper.Extensibility;

namespace XFBootstrapper.OpenWebAPI.ViewModels
{
    [DataContract]
    public class AdvancedSettingViewModel
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int value { get; set; }
        [DataMember]
        public string icon { get; set; }

        [DataMember]
        public List<object> settings { get; set; } = new List<object>();

        public AdvancedSettingViewModel(AdvancedSetting advSetting)
        {
            name = advSetting.Name;
            value = advSetting.Value;
            icon = advSetting.Icon;
        }
    }
}