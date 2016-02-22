using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The version of the operating system used by your users, such as XP for Windows or PPC for Macintosh.
	/// </summary>
	[Description("The version of the operating system used by your users, such as XP for Windows or PPC for Macintosh.")]
	public class OperatingSystemVersion: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="OperatingSystemVersion" />.
		/// </summary>
		public OperatingSystemVersion(): base("Operating System Version",true,"ga:operatingSystemVersion")
		{
			
		}
	}
}

