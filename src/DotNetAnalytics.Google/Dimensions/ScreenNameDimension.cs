namespace DotNetAnalytics.Google.Dimensions
{
	public class ScreenNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of the screen.
		/// </summary>
		public ScreenNameDimension(): base("Screen Name","The name of the screen.",true,"ga:screenName")
		{
			
		}
	}
}

