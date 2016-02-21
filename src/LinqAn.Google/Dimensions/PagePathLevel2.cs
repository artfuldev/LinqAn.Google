namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	This dimension rolls up all the page paths in the second hierarchical level in pagePath.
	/// </summary>
	public class PagePathLevel2: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PagePathLevel2" />.
		/// </summary>
		public PagePathLevel2(): base("Page path level 2","This dimension rolls up all the page paths in the second hierarchical level in pagePath.",false,"ga:pagePathLevel2")
		{
			
		}
	}
}

