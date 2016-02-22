using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this is a comma-separated set of tags associated with the social activity.
	/// </summary>
	[Description("For a social data hub activity, this is a comma-separated set of tags associated with the social activity.")]
	public class SocialActivityTagsSummary: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityTagsSummary" />.
		/// </summary>
		public SocialActivityTagsSummary(): base("Social Tags Summary",false,"ga:socialActivityTagsSummary")
		{
			
		}
	}
}

