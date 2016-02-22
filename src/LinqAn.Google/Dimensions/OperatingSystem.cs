using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod.
	/// </summary>
	[Description("The operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod.")]
	public class OperatingSystem: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="OperatingSystem" />.
		/// </summary>
		public OperatingSystem(): base("Operating System",true,"ga:operatingSystem")
		{
			
		}
	}
}

