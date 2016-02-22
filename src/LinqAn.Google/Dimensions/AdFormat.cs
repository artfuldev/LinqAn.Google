using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Your AdWords ad formats (Text, Image, Flash, Video, etc.).
	/// </summary>
	[Description("Your AdWords ad formats (Text, Image, Flash, Video, etc.).")]
	public class AdFormat: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdFormat" />.
		/// </summary>
		public AdFormat(): base("Ad Format",false,"ga:adFormat")
		{
			
		}
	}
}

