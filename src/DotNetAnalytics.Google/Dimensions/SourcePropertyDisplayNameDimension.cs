namespace DotNetAnalytics.Google.Dimensions
{
	public class SourcePropertyDisplayNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	Source property display name of roll-up properties. This is valid only for roll-up properties.
		/// </summary>
		public SourcePropertyDisplayNameDimension(): base("Source Property Display Name","Source property display name of roll-up properties. This is valid only for roll-up properties.",true,"ga:sourcePropertyDisplayName")
		{
			
		}
	}
}

