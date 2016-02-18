namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The Designated Market Area (DMA) from where traffic arrived.
	/// </summary>
	public class MetroDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="MetroDimension" />.
		/// </summary>
		public MetroDimension(): base("Metro","The Designated Market Area (DMA) from where traffic arrived.",true,"ga:metro")
		{
			
		}
	}
}

