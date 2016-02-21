namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of pageviews that resulted in a click on an AdX ad.
	/// </summary>
	public class AdxCTR: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdxCTR" />.
		/// </summary>
		public AdxCTR(): base("AdX CTR","The percentage of pageviews that resulted in a click on an AdX ad.",false,"ga:adxCTR")
		{
			
		}
	}
}

