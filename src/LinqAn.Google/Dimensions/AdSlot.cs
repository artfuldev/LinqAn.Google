namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The location of the advertisement on the hosting page (Top, RHS, or not set).
	/// </summary>
	public class AdSlot: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdSlot" />.
		/// </summary>
		public AdSlot(): base("Ad Slot","The location of the advertisement on the hosting page (Top, RHS, or not set).",true,"ga:adSlot")
		{
			
		}
	}
}

