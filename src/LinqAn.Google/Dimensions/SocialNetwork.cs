namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc.
	/// </summary>
	public class SocialNetwork: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SocialNetwork" />.
		/// </summary>
		public SocialNetwork(): base("Social Network","Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc.",false,"ga:socialNetwork")
		{
			
		}
	}
}

