namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged".
	/// </summary>
	public class SocialEngagementType: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialEngagementType" />.
		/// </summary>
		public SocialEngagementType(): base("Social Type","Engagement type. Possible values are \"Socially Engaged\" or \"Not Socially Engaged\".",false,"ga:socialEngagementType")
		{
			
		}
	}
}

