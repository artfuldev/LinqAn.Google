using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
	/// </summary>
	[Description("Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.")]
	public class ContentGroup1: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ContentGroup1" />.
		/// </summary>
		public ContentGroup1(): base("Page Group 1",true,"ga:contentGroup1")
		{
			
		}
	}
}

