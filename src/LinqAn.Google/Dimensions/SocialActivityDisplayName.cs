namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the title of the social activity posted by the social network user.
	/// </summary>
	public class SocialActivityDisplayName: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SocialActivityDisplayName" />.
		/// </summary>
		public SocialActivityDisplayName(): base("Display Name","For a social data hub activity, this value represents the title of the social activity posted by the social network user.",false,"ga:socialActivityDisplayName")
		{
			
		}
	}
}

