namespace DotNetAnalytics.Google.Dimensions
{
	public class ScreenDepthDimension: Dimension<string>
	{
		/// <summary>
		/// 	The number of screenviews per session reported as a string. Can be useful for historgrams.
		/// </summary>
		public ScreenDepthDimension(): base("Screen Depth","The number of screenviews per session reported as a string. Can be useful for historgrams.",true,"ga:screenDepth")
		{
			
		}
	}
}

