namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Your AdWords ad formats (Text, Image, Flash, Video, etc.).
	/// </summary>
	public class AdFormat: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdFormat" />.
		/// </summary>
		public AdFormat(): base("Ad Format","Your AdWords ad formats (Text, Image, Flash, Video, etc.).",false,"ga:adFormat")
		{
			
		}
	}
}

