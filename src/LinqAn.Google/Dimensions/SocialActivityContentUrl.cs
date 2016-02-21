namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the URL shared by the associated social network user.
	/// </summary>
	public class SocialActivityContentUrl: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityContentUrl" />.
		/// </summary>
		public SocialActivityContentUrl(): base("Shared URL","For a social data hub activity, this value represents the URL shared by the associated social network user.",false,"ga:socialActivityContentUrl")
		{
			
		}
	}
}

