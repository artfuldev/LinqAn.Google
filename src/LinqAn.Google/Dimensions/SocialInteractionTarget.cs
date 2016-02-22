using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For social interactions, a value representing the URL (or resource) which receives the social network action.
	/// </summary>
	[Description("For social interactions, a value representing the URL (or resource) which receives the social network action.")]
	public class SocialInteractionTarget: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialInteractionTarget" />.
		/// </summary>
		public SocialInteractionTarget(): base("Social Entity",false,"ga:socialInteractionTarget")
		{
			
		}
	}
}

