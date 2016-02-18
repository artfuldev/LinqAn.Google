namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The URLs to which your AdWords ads referred traffic.
	/// </summary>
	public class DestinationURLDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DestinationURLDimension" />.
		/// </summary>
		public DestinationURLDimension(): base("Destination URL","The URLs to which your AdWords ads referred traffic.",false,"ga:adDestinationUrl")
		{
			
		}
	}
}

