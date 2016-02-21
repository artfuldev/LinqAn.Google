namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link.
	/// </summary>
	public class ReferralPath: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ReferralPath" />.
		/// </summary>
		public ReferralPath(): base("Referral Path","The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link.",true,"ga:referralPath")
		{
			
		}
	}
}

