namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of single page (or single engagement hit) sessions for your property.
	/// </summary>
	public class Bounces: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Bounces" />.
		/// </summary>
		public Bounces(): base("Bounces","The total number of single page (or single engagement hit) sessions for your property.",true,"ga:bounces")
		{
			
		}
	}
}

