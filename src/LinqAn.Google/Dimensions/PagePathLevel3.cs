namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	This dimension rolls up all the page paths in the third hierarchical level in pagePath.
	/// </summary>
	public class PagePathLevel3: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PagePathLevel3" />.
		/// </summary>
		public PagePathLevel3(): base("Page path level 3","This dimension rolls up all the page paths in the third hierarchical level in pagePath.",false,"ga:pagePathLevel3")
		{
			
		}
	}
}

