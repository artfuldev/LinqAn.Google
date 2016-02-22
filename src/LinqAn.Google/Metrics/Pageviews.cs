using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of pageviews for your property.
	/// </summary>
	[Description("The total number of pageviews for your property.")]
	public class Pageviews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Pageviews" />.
		/// </summary>
		public Pageviews(): base("Pageviews",true,"ga:pageviews")
		{
			
		}
	}
}

