using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath
	/// </summary>
	[Description("The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath")]
	public class Entrances: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Entrances" />.
		/// </summary>
		public Entrances(): base("Entrances",true,"ga:entrances")
		{
			
		}
	}
}

