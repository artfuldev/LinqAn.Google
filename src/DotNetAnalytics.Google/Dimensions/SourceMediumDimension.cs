namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:source and ga:medium.
	/// </summary>
	public class SourceMediumDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SourceMediumDimension" />.
		/// </summary>
		public SourceMediumDimension(): base("Source / Medium","Combined values of ga:source and ga:medium.",true,"ga:sourceMedium")
		{
			
		}
	}
}

