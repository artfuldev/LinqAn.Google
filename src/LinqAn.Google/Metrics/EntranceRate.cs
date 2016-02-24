using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of pageviews in which this page was the entrance.
	/// </summary>
	[Description("The percentage of pageviews in which this page was the entrance.")]
	public class EntranceRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="EntranceRate" />.
		/// </summary>
		public EntranceRate(): base("Entrances / Pageviews",false,"ga:entranceRate")
		{
			
		}
	}
}

