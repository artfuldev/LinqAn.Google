using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The title of a page. Keep in mind that multiple pages might have the same page title.
	/// </summary>
	[Description("The title of a page. Keep in mind that multiple pages might have the same page title.")]
	public class PageTitle: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PageTitle" />.
		/// </summary>
		public PageTitle(): base("Page Title",true,"ga:pageTitle")
		{
			
		}
	}
}

