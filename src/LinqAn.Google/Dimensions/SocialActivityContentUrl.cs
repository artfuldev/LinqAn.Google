using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the URL shared by the associated social network user.
	/// </summary>
	[Description("For a social data hub activity, this value represents the URL shared by the associated social network user.")]
	public class SocialActivityContentUrl: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityContentUrl" />.
		/// </summary>
		public SocialActivityContentUrl(): base("Shared URL",false,"ga:socialActivityContentUrl")
		{
			
		}
	}
}

