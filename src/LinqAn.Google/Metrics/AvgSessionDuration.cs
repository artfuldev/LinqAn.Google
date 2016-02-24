using System.ComponentModel;
using System;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average duration of user sessions represented in total seconds.
	/// </summary>
	[Description("The average duration of user sessions represented in total seconds.")]
	public class AvgSessionDuration: Metric<TimeSpan>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgSessionDuration" />.
		/// </summary>
		public AvgSessionDuration(): base("Avg. Session Duration",false,"ga:avgSessionDuration")
		{
			
		}
	}
}

