namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The version of the operating system used by your users, such as XP for Windows or PPC for Macintosh.
	/// </summary>
	public class OperatingSystemVersion: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="OperatingSystemVersion" />.
		/// </summary>
		public OperatingSystemVersion(): base("Operating System Version","The version of the operating system used by your users, such as XP for Windows or PPC for Macintosh.",true,"ga:operatingSystemVersion")
		{
			
		}
	}
}

