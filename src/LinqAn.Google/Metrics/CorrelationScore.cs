namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Correlation Score for related products.
	/// </summary>
	public class CorrelationScore: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="CorrelationScore" />.
		/// </summary>
		public CorrelationScore(): base("Correlation Score","Correlation Score for related products.",false,"ga:correlationScore")
		{
			
		}
	}
}

