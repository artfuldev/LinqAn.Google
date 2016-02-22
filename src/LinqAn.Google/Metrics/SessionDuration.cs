using System.ComponentModel;
using System;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total duration of user sessions represented in total seconds.
	/// </summary>
	[Description("The total duration of user sessions represented in total seconds.")]
	public class SessionDuration: Metric<TimeSpan>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SessionDuration" />.
		/// </summary>
		public SessionDuration(): base("Session Duration",true,"ga:sessionDuration")
		{
			
		}
	}
}

