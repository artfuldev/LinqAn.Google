namespace DotNetAnalytics.Google.Dimensions
{
	public class JavaSupportDimension: Dimension<string>
	{
		/// <summary>
		/// 	Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.
		/// </summary>
		public JavaSupportDimension(): base("Java Support","Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.",true,"ga:javaEnabled")
		{
			
		}
	}
}

