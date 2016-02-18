namespace DotNetAnalytics.Google.Dimensions
{
	public class PreviousPagePathDimension: Dimension<string>
	{
		/// <summary>
		/// 	A page that was visited before another page on the same property. Typically used with the pagePath dimension.
		/// </summary>
		public PreviousPagePathDimension(): base("Previous Page Path","A page that was visited before another page on the same property. Typically used with the pagePath dimension.",false,"ga:previousPagePath")
		{
			
		}
	}
}

