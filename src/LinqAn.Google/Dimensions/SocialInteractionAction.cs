using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)
	/// </summary>
	[Description("For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)")]
	public class SocialInteractionAction: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialInteractionAction" />.
		/// </summary>
		public SocialInteractionAction(): base("Social Action",false,"ga:socialInteractionAction")
		{
			
		}
	}
}

