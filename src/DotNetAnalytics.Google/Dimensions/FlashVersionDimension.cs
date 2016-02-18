namespace DotNetAnalytics.Google.Dimensions
{
	public class FlashVersionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The versions of Flash supported by users' browsers, including minor versions.
		/// </summary>
		public FlashVersionDimension(): base("Flash Version","The versions of Flash supported by users' browsers, including minor versions.",true,"ga:flashVersion")
		{
			
		}
	}
}

