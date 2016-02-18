namespace DotNetAnalytics.Google.Dimensions
{
	public class OperatingSystemVersionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The version of the operating system used by your users, such as XP for Windows or PPC for Macintosh.
		/// </summary>
		public OperatingSystemVersionDimension(): base("Operating System Version","The version of the operating system used by your users, such as XP for Windows or PPC for Macintosh.",true,"ga:operatingSystemVersion")
		{
			
		}
	}
}

