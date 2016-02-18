namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	For social interactions, a value representing the URL (or resource) which receives the social network action.
	/// </summary>
	public class SocialEntityDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SocialEntityDimension" />.
		/// </summary>
		public SocialEntityDimension(): base("Social Entity","For social interactions, a value representing the URL (or resource) which receives the social network action.",false,"ga:socialInteractionTarget")
		{
			
		}
	}
}

