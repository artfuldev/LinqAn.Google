namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of unique events. Events in different sessions count as separate events.
	/// </summary>
	public class UniqueEvents: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="UniqueEvents" />.
		/// </summary>
		public UniqueEvents(): base("Unique Events","The number of unique events. Events in different sessions count as separate events.",false,"ga:uniqueEvents")
		{
			
		}
	}
}

