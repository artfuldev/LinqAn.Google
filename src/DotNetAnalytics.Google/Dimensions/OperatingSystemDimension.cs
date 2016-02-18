namespace DotNetAnalytics.Google.Dimensions
{
	public class OperatingSystemDimension: Dimension<string>
	{
		/// <summary>
		/// 	The operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod.
		/// </summary>
		public OperatingSystemDimension(): base("Operating System","The operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod.",true,"ga:operatingSystem")
		{
			
		}
	}
}

