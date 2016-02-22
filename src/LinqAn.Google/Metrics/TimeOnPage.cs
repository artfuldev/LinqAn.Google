using System.ComponentModel;
using System;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	How long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.
	/// </summary>
	[Description("How long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.")]
	public class TimeOnPage: Metric<TimeSpan>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TimeOnPage" />.
		/// </summary>
		public TimeOnPage(): base("Time on Page",true,"ga:timeOnPage")
		{
			
		}
	}
}

