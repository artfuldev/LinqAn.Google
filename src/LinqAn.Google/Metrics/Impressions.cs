namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Total number of campaign impressions.
	/// </summary>
	public class Impressions: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Impressions" />.
		/// </summary>
		public Impressions(): base("Impressions","Total number of campaign impressions.",false,"ga:impressions")
		{
			
		}
	}
}

