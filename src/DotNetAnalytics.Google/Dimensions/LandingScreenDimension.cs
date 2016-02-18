namespace DotNetAnalytics.Google.Dimensions
{
	public class LandingScreenDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of the first screen viewed.
		/// </summary>
		public LandingScreenDimension(): base("Landing Screen","The name of the first screen viewed.",true,"ga:landingScreenName")
		{
			
		}
	}
}

