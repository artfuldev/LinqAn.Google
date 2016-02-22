using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Product revenue in local currency.
	/// </summary>
	[Description("Product revenue in local currency.")]
	public class LocalItemRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LocalItemRevenue" />.
		/// </summary>
		public LocalItemRevenue(): base("Local Product Revenue",true,"ga:localItemRevenue")
		{
			
		}
	}
}

