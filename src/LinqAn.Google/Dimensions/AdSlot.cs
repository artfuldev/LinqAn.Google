using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The location of the advertisement on the hosting page (Top, RHS, or not set).
	/// </summary>
	[Description("The location of the advertisement on the hosting page (Top, RHS, or not set).")]
	public class AdSlot: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdSlot" />.
		/// </summary>
		public AdSlot(): base("Ad Slot",true,"ga:adSlot")
		{
			
		}
	}
}

