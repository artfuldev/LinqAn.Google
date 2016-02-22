using System.ComponentModel;
using System;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The session duration where a use of your internal search feature occurred.
	/// </summary>
	[Description("The session duration where a use of your internal search feature occurred.")]
	public class SearchDuration: Metric<TimeSpan>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchDuration" />.
		/// </summary>
		public SearchDuration(): base("Time after Search",true,"ga:searchDuration")
		{
			
		}
	}
}

