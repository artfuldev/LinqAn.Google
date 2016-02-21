namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Source property display name of roll-up properties. This is valid only for roll-up properties.
	/// </summary>
	public class SourcePropertyDisplayName: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SourcePropertyDisplayName" />.
		/// </summary>
		public SourcePropertyDisplayName(): base("Source Property Display Name","Source property display name of roll-up properties. This is valid only for roll-up properties.",true,"ga:sourcePropertyDisplayName")
		{
			
		}
	}
}

