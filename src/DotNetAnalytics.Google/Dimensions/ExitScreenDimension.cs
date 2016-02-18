namespace DotNetAnalytics.Google.Dimensions
{
	public class ExitScreenDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of the screen when the user exited the application.
		/// </summary>
		public ExitScreenDimension(): base("Exit Screen","The name of the screen when the user exited the application.",true,"ga:exitScreenName")
		{
			
		}
	}
}

