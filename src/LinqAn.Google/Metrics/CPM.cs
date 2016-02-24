using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Cost per thousand impressions.
	/// </summary>
	[Description("Cost per thousand impressions.")]
	public class CPM: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CPM" />.
		/// </summary>
		public CPM(): base("CPM",false,"ga:CPM")
		{
			
		}
	}
}

