using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the title of the social activity posted by the social network user.
	/// </summary>
	[Description("For a social data hub activity, this value represents the title of the social activity posted by the social network user.")]
	public class SocialActivityDisplayName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityDisplayName" />.
		/// </summary>
		public SocialActivityDisplayName(): base("Display Name",false,"ga:socialActivityDisplayName")
		{
			
		}
	}
}

