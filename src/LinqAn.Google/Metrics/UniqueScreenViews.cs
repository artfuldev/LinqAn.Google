namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of unique screen views. Screen views in different sessions count a separate screen views.
	/// </summary>
	public class UniqueScreenviews: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="UniqueScreenviews" />.
		/// </summary>
		public UniqueScreenviews(): base("Unique Screen Views","The number of unique screen views. Screen views in different sessions count a separate screen views.",true,"ga:uniqueScreenviews")
		{
			
		}
	}
}

