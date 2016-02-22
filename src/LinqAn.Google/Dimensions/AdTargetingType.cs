using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).
	/// </summary>
	[Description("How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).")]
	public class AdTargetingType: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdTargetingType" />.
		/// </summary>
		public AdTargetingType(): base("Targeting Type",true,"ga:adTargetingType")
		{
			
		}
	}
}

