using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBootstrapper.Extensibility
{
    /// <summary>
    /// Represents a version number in the form
    /// MajorVersion.MinorVersion[[.BuildNumber].Revision] where build number and revision are optionally provided values.
    /// </summary>
    /// <seealso cref="System.IComparable{VersionNumber}"/> 
    public sealed class VersionNumber : IComparable<VersionNumber>
    {
        readonly int mMajorVersionNumber;
        /// <summary>
        /// Gets the major version number.
        /// </summary>
        /// <value>
        /// The major version number.
        /// </value>
        public int MajorVersionNumber => mMajorVersionNumber;

        readonly int mMinorVersionNumber;
        /// <summary>
        /// Gets the minor version number.
        /// </summary>
        /// <value>
        /// The minor version number.
        /// </value>
        public int MinorVersionNumber => mMinorVersionNumber;

        readonly int? mBuildNumber = null;
        /// <summary>
        /// Gets the build number.
        /// </summary>
        /// <value>
        /// The build number.
        /// </value>
        public int? BuildNumber => mBuildNumber;

        readonly int? mRevisionNumber = 0;

        /// <summary>
        /// Gets the revision.
        /// </summary>
        /// <value>
        /// The revision.
        /// </value>
        public int? RevisionNumber => mRevisionNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionNumber"/> class.
        /// </summary>
        /// <param name="majorVersion">The major version.</param>
        /// <param name="minorVersion">The minor version.</param>
        /// <param name="buildNumber">The build number.</param>
        /// <param name="revisionNumber">The revision number.</param>
        /// <exception cref="System.ArgumentException">
        /// Argument cannot be negative. - majorVersion
        /// or
        /// ARgument cannot be negative. - minorVersion
        /// or
        /// Argument cannot be negative. - buildNumber
        /// or
        /// Argument cannot be negative. - revisionNumber
        /// or
        /// If a revision number is specified, build number must also be provided. - buildNumber
        /// </exception>
        public VersionNumber(int majorVersion, int minorVersion, int? buildNumber = null, int? revisionNumber = null)
        {
            if (majorVersion < 0)
                throw new ArgumentException("Argument cannot be negative.", nameof(majorVersion));
            if (minorVersion < 0)
                throw new ArgumentException("ARgument cannot be negative.", nameof(minorVersion));
            if (buildNumber.HasValue && buildNumber < 0)
                throw new ArgumentException("Argument cannot be negative.", nameof(buildNumber));
            if (buildNumber.HasValue && revisionNumber < 0)
                throw new ArgumentException("Argument cannot be negative.", nameof(revisionNumber));
            if (revisionNumber.HasValue && !buildNumber.HasValue)
                throw new ArgumentException("If a revision number is specified, build number must also be provided.", nameof(buildNumber));

            mMajorVersionNumber = majorVersion;
            mMinorVersionNumber = minorVersion;
            mBuildNumber = buildNumber;
            mRevisionNumber = revisionNumber;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string versionString = $"{MajorVersionNumber}.{MinorVersionNumber}";
            if (BuildNumber.HasValue)
            {
                versionString = String.Concat(versionString, $".{BuildNumber}");

                if (RevisionNumber.HasValue)
                {
                    versionString = String.Concat(versionString, $".{RevisionNumber}");
                }
            }
            return versionString;
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other" /> parameter.Zero This object is equal to <paramref name="other" />. Greater than zero This object is greater than <paramref name="other" />.
        /// </returns>
        int IComparable<VersionNumber>.CompareTo(VersionNumber other)
        {
            if (this.MajorVersionNumber == other.MajorVersionNumber)
            {
                if (this.MinorVersionNumber == other.MinorVersionNumber)
                {
                    int thisBuildNumber = this.BuildNumber.HasValue ? this.BuildNumber.Value : 0;
                    int otherBuildNumber = other.BuildNumber.HasValue ? other.BuildNumber.Value : 0;

                    if (thisBuildNumber == otherBuildNumber)
                    {
                        int thisRevisionNumber = this.RevisionNumber.HasValue ? this.RevisionNumber.Value : 0;
                        int otherRevisionNumber = other.RevisionNumber.HasValue ? other.RevisionNumber.Value : 0;

                        if (thisRevisionNumber == otherRevisionNumber)
                        {
                            return 0;
                        }
                        else
                        {
                            return thisRevisionNumber.CompareTo(otherRevisionNumber);
                        }
                    }
                    else
                    {
                        return thisBuildNumber.CompareTo(otherBuildNumber);
                    }
                }
                else
                {
                    return this.MinorVersionNumber.CompareTo(other.MinorVersionNumber);
                }
            }
            else
            {
                return this.MajorVersionNumber.CompareTo(other.MajorVersionNumber);
            }
        }
    }
}
