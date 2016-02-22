using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.
	/// </summary>
	[Description("The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.")]
	public class DomainLookupTime: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DomainLookupTime" />.
		/// </summary>
		public DomainLookupTime(): base("Domain Lookup Time (ms)",false,"ga:domainLookupTime")
		{
			
		}
	}
}

