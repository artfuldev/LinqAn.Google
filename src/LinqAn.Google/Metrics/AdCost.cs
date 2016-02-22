using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account.
	/// </summary>
	[Description("Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account.")]
	public class AdCost: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdCost" />.
		/// </summary>
		public AdCost(): base("Cost",false,"ga:adCost")
		{
			
		}
	}
}

