using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link.
	/// </summary>
	[Description("The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link.")]
	public class ReferralPath: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ReferralPath" />.
		/// </summary>
		public ReferralPath(): base("Referral Path",true,"ga:referralPath")
		{
			
		}
	}
}

