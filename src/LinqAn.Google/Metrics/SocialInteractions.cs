namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of social interactions.
	/// </summary>
	public class SocialInteractions: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SocialInteractions" />.
		/// </summary>
		public SocialInteractions(): base("Social Actions","The total number of social interactions.",false,"ga:socialInteractions")
		{
			
		}
	}
}

