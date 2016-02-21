namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)
	/// </summary>
	public class SocialInteractionAction: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialInteractionAction" />.
		/// </summary>
		public SocialInteractionAction(): base("Social Action","For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)",false,"ga:socialInteractionAction")
		{
			
		}
	}
}

