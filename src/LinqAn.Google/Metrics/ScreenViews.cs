namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of screenviews.
	/// </summary>
	public class Screenviews: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Screenviews" />.
		/// </summary>
		public Screenviews(): base("Screen Views","The total number of screenviews.",true,"ga:screenviews")
		{
			
		}
	}
}

