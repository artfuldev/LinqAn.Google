namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For social interactions, a value representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1)
	/// </summary>
	public class SocialInteractionNetworkAction: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialInteractionNetworkAction" />.
		/// </summary>
		public SocialInteractionNetworkAction(): base("Social Network and Action","For social interactions, a value representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1)",false,"ga:socialInteractionNetworkAction")
		{
			
		}
	}
}

