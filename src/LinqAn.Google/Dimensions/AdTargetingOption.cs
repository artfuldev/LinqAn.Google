using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	How you manage your ads on the content network. Values are Automatic placements or Managed placements.
	/// </summary>
	[Description("How you manage your ads on the content network. Values are Automatic placements or Managed placements.")]
	public class AdTargetingOption: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdTargetingOption" />.
		/// </summary>
		public AdTargetingOption(): base("Placement Type",false,"ga:adTargetingOption")
		{
			
		}
	}
}

