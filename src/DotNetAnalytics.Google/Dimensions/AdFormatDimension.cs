namespace DotNetAnalytics.Google.Dimensions
{
	public class AdFormatDimension: Dimension<string>
	{
		/// <summary>
		/// 	Your AdWords ad formats (Text, Image, Flash, Video, etc.).
		/// </summary>
		public AdFormatDimension(): base("Ad Format","Your AdWords ad formats (Text, Image, Flash, Video, etc.).",false,"ga:adFormat")
		{
			
		}
	}
}

