namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the type of social action and the social network where the activity originated.
	/// </summary>
	public class SocialActivityNetworkAction: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SocialActivityNetworkAction" />.
		/// </summary>
		public SocialActivityNetworkAction(): base("Social Network and Action","For a social data hub activity, this value represents the type of social action and the social network where the activity originated.",false,"ga:socialActivityNetworkAction")
		{
			
		}
	}
}

