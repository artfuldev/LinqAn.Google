using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average number of pages viewed during a session, including repeated views of a single page.
	/// </summary>
	[Description("The average number of pages viewed during a session, including repeated views of a single page.")]
	public class PageviewsPerSession: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PageviewsPerSession" />.
		/// </summary>
		public PageviewsPerSession(): base("Pages / Session",false,"ga:pageviewsPerSession")
		{
			
		}
	}
}

