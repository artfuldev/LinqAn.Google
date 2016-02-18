namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Source property display name of roll-up properties. This is valid only for roll-up properties.
	/// </summary>
	public class SourcePropertyDisplayNameDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SourcePropertyDisplayNameDimension" />.
		/// </summary>
		public SourcePropertyDisplayNameDimension(): base("Source Property Display Name","Source property display name of roll-up properties. This is valid only for roll-up properties.",true,"ga:sourcePropertyDisplayName")
		{
			
		}
	}
}

