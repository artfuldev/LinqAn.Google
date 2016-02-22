using System.ComponentModel;
using System;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The time spent viewing the current screen.
	/// </summary>
	[Description("The time spent viewing the current screen.")]
	public class TimeOnScreen: Metric<TimeSpan>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TimeOnScreen" />.
		/// </summary>
		public TimeOnScreen(): base("Time on Screen",true,"ga:timeOnScreen")
		{
			
		}
	}
}

