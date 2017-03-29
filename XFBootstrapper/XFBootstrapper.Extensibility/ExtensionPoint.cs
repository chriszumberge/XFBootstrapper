using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZESoft.Common;

namespace XFBootstrapper.Extensibility
{
    public sealed class ExtensionPoint : TypeSafeEnum
    {
        private ExtensionPoint(int value, string name) : base(value, name) { }

        public ExtensionPoint Authentication = new ExtensionPoint(ExtensionPoints.Authentication, nameof(ExtensionPoints.Authentication).Replace("_", " "));
        public ExtensionPoint ContentManagement = new ExtensionPoint(ExtensionPoints.Content_Management, nameof(ExtensionPoints.Content_Management).Replace("_", " "));
        public ExtensionPoint Data = new ExtensionPoint(ExtensionPoints.Data, nameof(ExtensionPoints.Data).Replace("_", " "));
        public ExtensionPoint Storage = new ExtensionPoint(ExtensionPoints.Storage, nameof(ExtensionPoints.Storage).Replace("_", " "));
        public ExtensionPoint PushNotifications = new ExtensionPoint(ExtensionPoints.Push_Notifications, nameof(ExtensionPoints.Push_Notifications).Replace("_", " "));
        public ExtensionPoint MobileServices = new ExtensionPoint(ExtensionPoints.Mobile_Services, nameof(ExtensionPoints.Mobile_Services).Replace("_", " "));
        public ExtensionPoint Networking = new ExtensionPoint(ExtensionPoints.Networking, nameof(ExtensionPoints.Networking).Replace("_", " "));
        public ExtensionPoint IoT = new ExtensionPoint(ExtensionPoints.IoT, nameof(ExtensionPoints.IoT).Replace("_", " "));
        public ExtensionPoint UI = new ExtensionPoint(ExtensionPoints.UI, nameof(ExtensionPoints.UI).Replace("_", " "));
        public ExtensionPoint Analytics = new ExtensionPoint(ExtensionPoints.Analytics, nameof(ExtensionPoints.Analytics).Replace("_", " "));
        public ExtensionPoint Testing = new ExtensionPoint(ExtensionPoints.Testing, nameof(ExtensionPoints.Testing).Replace("_", " "));
        public ExtensionPoint AppLogic = new ExtensionPoint(ExtensionPoints.App_Logic, nameof(ExtensionPoints.App_Logic).Replace("_", " "));
        public ExtensionPoint ContinuousIntegration = new ExtensionPoint(ExtensionPoints.Continuous_Integration, nameof(ExtensionPoints.Continuous_Integration).Replace("_", " "));
        public ExtensionPoint Deployment = new ExtensionPoint(ExtensionPoints.Deployment, nameof(ExtensionPoints.Deployment).Replace("_", " "));

        public class ExtensionPoints
        {
            public const int Authentication = 1;
            public const int Content_Management = 2;
            public const int Data = 3;
            public const int Storage = 4;
            public const int Push_Notifications = 5;
            public const int Mobile_Services = 6;
            public const int Networking = 7;
            public const int IoT = 8;
            public const int UI = 9;
            public const int Analytics = 10;
            public const int Testing = 11;
            public const int App_Logic = 12;
            public const int Continuous_Integration = 13;
            public const int Deployment = 14;
            
        }
    }
}
