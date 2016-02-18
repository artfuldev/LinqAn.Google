namespace DotNetAnalytics.Google.Dimensions
{
	public class SocialEntityDimension: Dimension<string>
	{
		/// <summary>
		/// 	For social interactions, a value representing the URL (or resource) which receives the social network action.
		/// </summary>
		public SocialEntityDimension(): base("Social Entity","For social interactions, a value representing the URL (or resource) which receives the social network action.",false,"ga:socialInteractionTarget")
		{
			
		}
	}
}

