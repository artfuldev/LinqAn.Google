namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of activities where a content URL was shared / mentioned on a social data hub partner network.
	/// </summary>
	public class SocialActivities: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivities" />.
		/// </summary>
		public SocialActivities(): base("Data Hub Activities","The total number of activities where a content URL was shared / mentioned on a social data hub partner network.",false,"ga:socialActivities")
		{
			
		}
	}
}

