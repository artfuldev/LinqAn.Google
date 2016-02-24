using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The cost per transaction for your property.
	/// </summary>
	[Description("The cost per transaction for your property.")]
	public class CostPerTransaction: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CostPerTransaction" />.
		/// </summary>
		public CostPerTransaction(): base("Cost per Transaction",false,"ga:costPerTransaction")
		{
			
		}
	}
}

