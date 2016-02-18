namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	A page that was visited before another page on the same property. Typically used with the pagePath dimension.
	/// </summary>
	public class PreviousPagePathDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PreviousPagePathDimension" />.
		/// </summary>
		public PreviousPagePathDimension(): base("Previous Page Path","A page that was visited before another page on the same property. Typically used with the pagePath dimension.",false,"ga:previousPagePath")
		{
			
		}
	}
}

