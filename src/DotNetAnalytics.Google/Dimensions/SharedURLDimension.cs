namespace DotNetAnalytics.Google.Dimensions
{
	public class SharedURLDimension: Dimension<string>
	{
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL shared by the associated social network user.
		/// </summary>
		public SharedURLDimension(): base("Shared URL","For a social data hub activity, this value represents the URL shared by the associated social network user.",false,"ga:socialActivityContentUrl")
		{
			
		}
	}
}

