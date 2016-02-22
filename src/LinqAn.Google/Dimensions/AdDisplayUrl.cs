using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The URLs your AdWords ads displayed.
	/// </summary>
	[Description("The URLs your AdWords ads displayed.")]
	public class AdDisplayUrl: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdDisplayUrl" />.
		/// </summary>
		public AdDisplayUrl(): base("Display URL",false,"ga:adDisplayUrl")
		{
			
		}
	}
}

