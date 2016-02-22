using System.ComponentModel;
using System;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time users spent on a screen in seconds.
	/// </summary>
	[Description("The average amount of time users spent on a screen in seconds.")]
	public class AvgScreenviewDuration: Metric<TimeSpan>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgScreenviewDuration" />.
		/// </summary>
		public AvgScreenviewDuration(): base("Avg. Time on Screen",false,"ga:avgScreenviewDuration")
		{
			
		}
	}
}

