namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The name of your AdWords ad group.
	/// </summary>
	public class AdGroupDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdGroupDimension" />.
		/// </summary>
		public AdGroupDimension(): base("Ad Group","The name of your AdWords ad group.",true,"ga:adGroup")
		{
			
		}
	}
}

