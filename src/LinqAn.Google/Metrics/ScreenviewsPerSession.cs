using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average number of screenviews per session.
	/// </summary>
	[Description("The average number of screenviews per session.")]
	public class ScreenviewsPerSession: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ScreenviewsPerSession" />.
		/// </summary>
		public ScreenviewsPerSession(): base("Screens / Session",false,"ga:screenviewsPerSession")
		{
			
		}
	}
}

