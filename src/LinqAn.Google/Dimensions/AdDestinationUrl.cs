using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The URLs to which your AdWords ads referred traffic.
	/// </summary>
	[Description("The URLs to which your AdWords ads referred traffic.")]
	public class AdDestinationUrl: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdDestinationUrl" />.
		/// </summary>
		public AdDestinationUrl(): base("Destination URL",false,"ga:adDestinationUrl")
		{
			
		}
	}
}

