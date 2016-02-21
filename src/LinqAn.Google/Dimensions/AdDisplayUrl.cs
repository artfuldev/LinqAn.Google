namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The URLs your AdWords ads displayed.
	/// </summary>
	public class AdDisplayUrl: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdDisplayUrl" />.
		/// </summary>
		public AdDisplayUrl(): base("Display URL","The URLs your AdWords ads displayed.",false,"ga:adDisplayUrl")
		{
			
		}
	}
}

