using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
	/// </summary>
	[Description("Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.")]
	public class ContentGroup2: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ContentGroup2" />.
		/// </summary>
		public ContentGroup2(): base("Page Group 2",true,"ga:contentGroup2")
		{
			
		}
	}
}

