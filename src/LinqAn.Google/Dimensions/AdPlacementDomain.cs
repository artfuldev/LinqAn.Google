using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The domains where your ads on the content network were placed.
	/// </summary>
	[Description("The domains where your ads on the content network were placed.")]
	public class AdPlacementDomain: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdPlacementDomain" />.
		/// </summary>
		public AdPlacementDomain(): base("Placement Domain",false,"ga:adPlacementDomain")
		{
			
		}
	}
}

