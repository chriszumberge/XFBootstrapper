using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZESoft.Common;

namespace XFBootstrapper.Extensibility
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ZESoft.Common.TypeSafeEnum" />
    public sealed class ExtensionPoint : TypeSafeEnum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionPoint"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        /// <param name="icon">The icon.</param>
        private ExtensionPoint(int value, string name, string icon) : base(value, name)
        {
            mIcon = icon;
        }
        /// <summary>
        /// Gets the icon.
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        public string Icon => mIcon;
        private string mIcon { get; set; }

        public static ExtensionPoint Authentication = new ExtensionPoint(ExtensionPoints.Authentication, nameof(ExtensionPoints.Authentication).Replace("_", " "), "person");
        public static ExtensionPoint ContentManagement = new ExtensionPoint(ExtensionPoints.Content_Management, nameof(ExtensionPoints.Content_Management).Replace("_", " "), "image");
        public static ExtensionPoint Data = new ExtensionPoint(ExtensionPoints.Data, nameof(ExtensionPoints.Data).Replace("_", " "), "insert_drive_file");
        public static ExtensionPoint Storage = new ExtensionPoint(ExtensionPoints.Storage, nameof(ExtensionPoints.Storage).Replace("_", " "), "storage");
        public static ExtensionPoint PushNotifications = new ExtensionPoint(ExtensionPoints.Push_Notifications, nameof(ExtensionPoints.Push_Notifications).Replace("_", " "), "notifications");
        public static ExtensionPoint MobileServices = new ExtensionPoint(ExtensionPoints.Mobile_Services, nameof(ExtensionPoints.Mobile_Services).Replace("_", " "), "smartphone");
        public static ExtensionPoint Networking = new ExtensionPoint(ExtensionPoints.Networking, nameof(ExtensionPoints.Networking).Replace("_", " "), "network_cell");
        public static ExtensionPoint IoT = new ExtensionPoint(ExtensionPoints.Internet_of_Things, nameof(ExtensionPoints.Internet_of_Things).Replace("_", " "), "device_hub");
        public static ExtensionPoint UI = new ExtensionPoint(ExtensionPoints.User_Interface, nameof(ExtensionPoints.User_Interface).Replace("_", " "), "view_quilt");
        public static ExtensionPoint Analytics = new ExtensionPoint(ExtensionPoints.Analytics, nameof(ExtensionPoints.Analytics).Replace("_", " "), "search");
        public static ExtensionPoint Testing = new ExtensionPoint(ExtensionPoints.Testing, nameof(ExtensionPoints.Testing).Replace("_", " "), "done_all");
        public static ExtensionPoint AppLogic = new ExtensionPoint(ExtensionPoints.App_Logic, nameof(ExtensionPoints.App_Logic).Replace("_", " "), "code");
        public static ExtensionPoint ContinuousIntegration = new ExtensionPoint(ExtensionPoints.Continuous_Integration, nameof(ExtensionPoints.Continuous_Integration).Replace("_", " "), "file_upload");
        public static ExtensionPoint Deployment = new ExtensionPoint(ExtensionPoints.Deployment, nameof(ExtensionPoints.Deployment).Replace("_", " "), "cloud");

        public class ExtensionPoints
        {
            public const int Authentication = 1;
            public const int Content_Management = 2;
            public const int Data = 3;
            public const int Storage = 4;
            public const int Push_Notifications = 5;
            public const int Mobile_Services = 6;
            public const int Networking = 7;
            public const int Internet_of_Things = 8;
            public const int User_Interface = 9;
            public const int Analytics = 10;
            public const int Testing = 11;
            public const int App_Logic = 12;
            public const int Continuous_Integration = 13;
            public const int Deployment = 14;

        }

        public static List<ExtensionPoint> GetAll()
        {
            return new List<ExtensionPoint>
            {
                Authentication,
                ContentManagement,
                Data,
                Storage,
                PushNotifications,
                MobileServices,
                Networking,
                IoT,
                UI,
                Analytics,
                Testing,
                AppLogic,
                ContinuousIntegration,
                Deployment
            };
        }
    }
}
