using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The URLs where your ads on the content network were placed.
	/// </summary>
	[Description("The URLs where your ads on the content network were placed.")]
	public class AdPlacementUrl: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdPlacementUrl" />.
		/// </summary>
		public AdPlacementUrl(): base("Placement URL",false,"ga:adPlacementUrl")
		{
			
		}
	}
}

