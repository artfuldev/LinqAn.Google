namespace DotNetAnalytics.Google.Dimensions
{
	public class DestinationURLDimension: Dimension<string>
	{
		/// <summary>
		/// 	The URLs to which your AdWords ads referred traffic.
		/// </summary>
		public DestinationURLDimension(): base("Destination URL","The URLs to which your AdWords ads referred traffic.",false,"ga:adDestinationUrl")
		{
			
		}
	}
}

