using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The cost per conversion (including ecommerce and goal conversions) for your property.
	/// </summary>
	[Description("The cost per conversion (including ecommerce and goal conversions) for your property.")]
	public class CostPerConversion: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CostPerConversion" />.
		/// </summary>
		public CostPerConversion(): base("Cost per Conversion",false,"ga:costPerConversion")
		{
			
		}
	}
}

