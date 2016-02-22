using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Total number of campaign impressions.
	/// </summary>
	[Description("Total number of campaign impressions.")]
	public class Impressions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Impressions" />.
		/// </summary>
		public Impressions(): base("Impressions",false,"ga:impressions")
		{
			
		}
	}
}

