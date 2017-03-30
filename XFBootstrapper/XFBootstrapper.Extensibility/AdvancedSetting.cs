using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZESoft.Common;

namespace XFBootstrapper.Extensibility
{
    public sealed class AdvancedSetting : TypeSafeEnum
    {
        private AdvancedSetting(int value, string name, string icon) : base(value, name)
        {
            mIcon = icon;
        }
        public string Icon => mIcon;
        private string mIcon { get; set; }

        public static AdvancedSetting BusinessLayer = new AdvancedSetting(AdvancedSettings.Business_Layer, nameof(AdvancedSettings.Business_Layer).Replace("_", " "), "business_center");
        public static AdvancedSetting AppBackEnd = new AdvancedSetting(AdvancedSettings.Application_Back_End, nameof(AdvancedSettings.Application_Back_End).Replace("_", " "), "cloud_download");
        public static AdvancedSetting DatabaseConfiguration = new AdvancedSetting(AdvancedSettings.Database_Configuration, nameof(AdvancedSettings.Database_Configuration).Replace("_", " "), "settings_applications");

        public class AdvancedSettings
        {
            public const int Business_Layer = 1;
            public const int Application_Back_End = 2;
            public const int Database_Configuration = 3;
        }

        public static List<AdvancedSetting> GetAll()
        {
            return new List<AdvancedSetting>
            {
                BusinessLayer,
                AppBackEnd,
                DatabaseConfiguration
            };
        }
    }
}
