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
    public sealed class ProjectPlatform : TypeSafeEnum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectPlatform"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="allowedProjectTypes">The allowed project types.</param>
        private ProjectPlatform(int value, string name, string icon, ProjectType[] allowedProjectTypes) : base(value, name)
        {
            mIcon = icon;
            mAllowedProjectTypes = allowedProjectTypes;
        }

        /// <summary>
        /// Gets the icon.
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        public string Icon => mIcon;
        readonly string mIcon;

        /// <summary>
        /// Gets the allowed project types.
        /// </summary>
        /// <value>
        /// The allowed project types.
        /// </value>
        public ProjectType[] AllowedProjectTypes => mAllowedProjectTypes;
        readonly ProjectType[] mAllowedProjectTypes;

        public static ProjectPlatform iPhone = new ProjectPlatform(ProjectPlatforms.iPhone, nameof(ProjectPlatforms.iPhone).Replace("_", " "), "phone_iphone", new ProjectType[] { ProjectType.Mobile });
        public static ProjectPlatform Android = new ProjectPlatform(ProjectPlatforms.Android, nameof(ProjectPlatforms.Android).Replace("_", " "), "phone_android", new ProjectType[] { ProjectType.Mobile });
        public static ProjectPlatform WindowsPhone = new ProjectPlatform(ProjectPlatforms.Windows_Phone, nameof(ProjectPlatforms.Windows_Phone).Replace("_", " "), "smartphone", new ProjectType[] { ProjectType.Mobile });
        public static ProjectPlatform DotNetMVC = new ProjectPlatform(ProjectPlatforms.Dot_Net_MVC, nameof(ProjectPlatforms.Dot_Net_MVC).Replace("_", " "), "", new ProjectType[] { ProjectType.Web });
        public static ProjectPlatform DotNetWebApi = new ProjectPlatform(ProjectPlatforms.Dot_Net_WebApi, nameof(ProjectPlatforms.Dot_Net_WebApi).Replace("_", " "), "", new ProjectType[] { ProjectType.Web });
        public static ProjectPlatform Website = new ProjectPlatform(ProjectPlatforms.Website, nameof(ProjectPlatforms.Website).Replace("_", " "), "", new ProjectType[] { ProjectType.Web });

        public class ProjectPlatforms
        {
            public const int iPhone = 1;
            public const int Android = 2;
            public const int Windows_Phone = 3;
            public const int Dot_Net_MVC = 4;
            public const int Dot_Net_WebApi = 5;
            public const int Website = 6;
        }

        public static List<ProjectPlatform> GetAll()
        {
            return new List<ProjectPlatform>
            {
                iPhone,
                Android,
                WindowsPhone,
                DotNetMVC,
                DotNetWebApi,
                Website
            };
        }
    }
}
