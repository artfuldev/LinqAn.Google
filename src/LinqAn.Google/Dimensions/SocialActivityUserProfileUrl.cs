namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the URL of the associated user's social network profile.
	/// </summary>
	public class SocialActivityUserProfileUrl: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityUserProfileUrl" />.
		/// </summary>
		public SocialActivityUserProfileUrl(): base("User Profile URL","For a social data hub activity, this value represents the URL of the associated user's social network profile.",false,"ga:socialActivityUserProfileUrl")
		{
			
		}
	}
}

