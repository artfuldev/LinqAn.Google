using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of times users have clicked on an ad to reach your property.
	/// </summary>
	[Description("The total number of times users have clicked on an ad to reach your property.")]
	public class AdClicks: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdClicks" />.
		/// </summary>
		public AdClicks(): base("Clicks",false,"ga:adClicks")
		{
			
		}
	}
}

