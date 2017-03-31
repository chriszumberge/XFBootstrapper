using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBootstrapper.Extensibility
{
    public interface IProjectContext
    {
        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        /// <value>
        /// The name of the project.
        /// </value>
        string ProjectName { get; }
        /// <summary>
        /// Gets the type of the project.
        /// </summary>
        /// <value>
        /// The type of the project.
        /// </value>
        ProjectType ProjectType { get; }
        /// <summary>
        /// Gets the project platforms.
        /// </summary>
        /// <value>
        /// The project platforms.
        /// </value>
        List<ProjectPlatform> ProjectPlatforms { get; }

    }
}
