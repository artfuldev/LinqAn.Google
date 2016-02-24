using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared).
	/// </summary>
	[Description("Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared).")]
	public class CTR: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CTR" />.
		/// </summary>
		public CTR(): base("CTR",false,"ga:CTR")
		{
			
		}
	}
}

