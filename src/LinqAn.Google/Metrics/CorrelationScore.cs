using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Correlation Score for related products.
	/// </summary>
	[Description("Correlation Score for related products.")]
	public class CorrelationScore: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CorrelationScore" />.
		/// </summary>
		public CorrelationScore(): base("Correlation Score",false,"ga:correlationScore")
		{
			
		}
	}
}

