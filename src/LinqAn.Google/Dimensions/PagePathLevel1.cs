namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	This dimension rolls up all the page paths in the first hierarchical level in pagePath.
	/// </summary>
	public class PagePathLevel1: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PagePathLevel1" />.
		/// </summary>
		public PagePathLevel1(): base("Page path level 1","This dimension rolls up all the page paths in the first hierarchical level in pagePath.",false,"ga:pagePathLevel1")
		{
			
		}
	}
}

