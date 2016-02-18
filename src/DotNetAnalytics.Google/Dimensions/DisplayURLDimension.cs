namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The URLs your AdWords ads displayed.
	/// </summary>
	public class DisplayURLDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DisplayURLDimension" />.
		/// </summary>
		public DisplayURLDimension(): base("Display URL","The URLs your AdWords ads displayed.",false,"ga:adDisplayUrl")
		{
			
		}
	}
}

