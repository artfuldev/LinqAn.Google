using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times AdX ads were clicked on your site.
	/// </summary>
	[Description("The number of times AdX ads were clicked on your site.")]
	public class AdxClicks: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdxClicks" />.
		/// </summary>
		public AdxClicks(): base("AdX Clicks",true,"ga:adxClicks")
		{
			
		}
	}
}

