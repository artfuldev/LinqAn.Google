namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the title of the social activity posted by the social network user.
	/// </summary>
	public class DisplayNameDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DisplayNameDimension" />.
		/// </summary>
		public DisplayNameDimension(): base("Display Name","For a social data hub activity, this value represents the title of the social activity posted by the social network user.",false,"ga:socialActivityDisplayName")
		{
			
		}
	}
}

