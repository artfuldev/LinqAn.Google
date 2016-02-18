namespace DotNetAnalytics.Google.Dimensions
{
	public class DisplayURLDimension: Dimension<string>
	{
		/// <summary>
		/// 	The URLs your AdWords ads displayed.
		/// </summary>
		public DisplayURLDimension(): base("Display URL","The URLs your AdWords ads displayed.",false,"ga:adDisplayUrl")
		{
			
		}
	}
}

