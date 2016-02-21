namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The screen resolution of users' screens. For example: 1024x738.
	/// </summary>
	public class ScreenResolution: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ScreenResolution" />.
		/// </summary>
		public ScreenResolution(): base("Screen Resolution","The screen resolution of users' screens. For example: 1024x738.",true,"ga:screenResolution")
		{
			
		}
	}
}

