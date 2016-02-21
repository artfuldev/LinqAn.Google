namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The URLs to which your AdWords ads referred traffic.
	/// </summary>
	public class AdDestinationUrl: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdDestinationUrl" />.
		/// </summary>
		public AdDestinationUrl(): base("Destination URL","The URLs to which your AdWords ads referred traffic.",false,"ga:adDestinationUrl")
		{
			
		}
	}
}

