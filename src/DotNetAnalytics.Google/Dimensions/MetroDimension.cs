namespace DotNetAnalytics.Google.Dimensions
{
	public class MetroDimension: Dimension<string>
	{
		/// <summary>
		/// 	The Designated Market Area (DMA) from where traffic arrived.
		/// </summary>
		public MetroDimension(): base("Metro","The Designated Market Area (DMA) from where traffic arrived.",true,"ga:metro")
		{
			
		}
	}
}

