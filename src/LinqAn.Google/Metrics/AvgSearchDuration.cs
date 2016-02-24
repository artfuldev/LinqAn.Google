using System.ComponentModel;
using System;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average time (in seconds) users spent on your property after searching.
	/// </summary>
	[Description("The average time (in seconds) users spent on your property after searching.")]
	public class AvgSearchDuration: Metric<TimeSpan>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgSearchDuration" />.
		/// </summary>
		public AvgSearchDuration(): base("Time after Search",false,"ga:avgSearchDuration")
		{
			
		}
	}
}

