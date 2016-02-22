using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The versions of Flash supported by users' browsers, including minor versions.
	/// </summary>
	[Description("The versions of Flash supported by users' browsers, including minor versions.")]
	public class FlashVersion: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="FlashVersion" />.
		/// </summary>
		public FlashVersion(): base("Flash Version",true,"ga:flashVersion")
		{
			
		}
	}
}

