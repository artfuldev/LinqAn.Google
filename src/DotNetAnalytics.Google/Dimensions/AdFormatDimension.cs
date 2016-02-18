namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Your AdWords ad formats (Text, Image, Flash, Video, etc.).
	/// </summary>
	public class AdFormatDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdFormatDimension" />.
		/// </summary>
		public AdFormatDimension(): base("Ad Format","Your AdWords ad formats (Text, Image, Flash, Video, etc.).",false,"ga:adFormat")
		{
			
		}
	}
}

