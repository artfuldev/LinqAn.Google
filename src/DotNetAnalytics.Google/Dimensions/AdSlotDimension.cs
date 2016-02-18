namespace DotNetAnalytics.Google.Dimensions
{
	public class AdSlotDimension: Dimension<string>
	{
		/// <summary>
		/// 	The location of the advertisement on the hosting page (Top, RHS, or not set).
		/// </summary>
		public AdSlotDimension(): base("Ad Slot","The location of the advertisement on the hosting page (Top, RHS, or not set).",true,"ga:adSlot")
		{
			
		}
	}
}

