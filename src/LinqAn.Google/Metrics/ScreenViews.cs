using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of screenviews.
	/// </summary>
	[Description("The total number of screenviews.")]
	public class Screenviews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Screenviews" />.
		/// </summary>
		public Screenviews(): base("Screen Views",true,"ga:screenviews")
		{
			
		}
	}
}

