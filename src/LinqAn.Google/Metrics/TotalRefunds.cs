using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of refunds that have been issued (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of refunds that have been issued (Enhanced Ecommerce).")]
	public class TotalRefunds: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TotalRefunds" />.
		/// </summary>
		public TotalRefunds(): base("Refunds",true,"ga:totalRefunds")
		{
			
		}
	}
}

