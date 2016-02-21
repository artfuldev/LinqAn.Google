namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the first screen viewed.
	/// </summary>
	public class LandingScreenName: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LandingScreenName" />.
		/// </summary>
		public LandingScreenName(): base("Landing Screen","The name of the first screen viewed.",true,"ga:landingScreenName")
		{
			
		}
	}
}

