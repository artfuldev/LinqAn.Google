namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The versions of Flash supported by users' browsers, including minor versions.
	/// </summary>
	public class FlashVersion: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="FlashVersion" />.
		/// </summary>
		public FlashVersion(): base("Flash Version","The versions of Flash supported by users' browsers, including minor versions.",true,"ga:flashVersion")
		{
			
		}
	}
}

