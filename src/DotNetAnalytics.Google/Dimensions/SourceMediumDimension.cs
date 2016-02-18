namespace DotNetAnalytics.Google.Dimensions
{
	public class SourceMediumDimension: Dimension<string>
	{
		/// <summary>
		/// 	Combined values of ga:source and ga:medium.
		/// </summary>
		public SourceMediumDimension(): base("Source / Medium","Combined values of ga:source and ga:medium.",true,"ga:sourceMedium")
		{
			
		}
	}
}

