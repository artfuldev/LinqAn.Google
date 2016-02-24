using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time (in seconds) spent in DNS lookup for this page.
	/// </summary>
	[Description("The average amount of time (in seconds) spent in DNS lookup for this page.")]
	public class AvgDomainLookupTime: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgDomainLookupTime" />.
		/// </summary>
		public AvgDomainLookupTime(): base("Avg. Domain Lookup Time (sec)",false,"ga:avgDomainLookupTime")
		{
			
		}
	}
}

