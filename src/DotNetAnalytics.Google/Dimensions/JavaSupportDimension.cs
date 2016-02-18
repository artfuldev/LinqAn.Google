namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.
	/// </summary>
	public class JavaSupportDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="JavaSupportDimension" />.
		/// </summary>
		public JavaSupportDimension(): base("Java Support","Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.",true,"ga:javaEnabled")
		{
			
		}
	}
}

