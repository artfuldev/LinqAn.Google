using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
	/// </summary>
	[Description("Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.")]
	public class ContentGroup5: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ContentGroup5" />.
		/// </summary>
		public ContentGroup5(): base("Page Group 5",true,"ga:contentGroup5")
		{
			
		}
	}
}

