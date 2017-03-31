using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZESoft.Common;

namespace XFBootstrapper.Extensibility
{
    public sealed class ProjectType : TypeSafeEnum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectType"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        /// <param name="icon">The icon.</param>
        /// <seealso cref="ZESoft.Common.TypeSafeEnum"/>
        private ProjectType(int value, string name, string[] icons) : base(value, name)
        {
            mIcons = icons;
        }
        /// <summary>
        /// Gets the icon.
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        public string[] Icons => mIcons;
        private string[] mIcons { get; set; }

        public static ProjectType Mobile = new ProjectType(ProjectTypes.Mobile, nameof(ProjectTypes.Mobile).Replace("_", " "), new string[] { "phone_android", "phone_iphone" });
        public static ProjectType Web = new ProjectType(ProjectTypes.Web, nameof(ProjectTypes.Web).Replace("_", " "), new string[] { "desktop_mac", "web" });

        public class ProjectTypes
        {
            public const int Mobile = 1;
            public const int Web = 2;
        }

        public static List<ProjectType> GetAll()
        {
            return new List<ProjectType>
            {
                Mobile,
                Web
            };
        }
    }
}
