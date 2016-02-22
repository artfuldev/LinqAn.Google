using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of pageviews that resulted in a click on an AdX ad.
	/// </summary>
	[Description("The percentage of pageviews that resulted in a click on an AdX ad.")]
	public class AdxCTR: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdxCTR" />.
		/// </summary>
		public AdxCTR(): base("AdX CTR",false,"ga:adxCTR")
		{
			
		}
	}
}

