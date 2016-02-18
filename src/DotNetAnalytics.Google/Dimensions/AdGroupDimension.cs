namespace DotNetAnalytics.Google.Dimensions
{
	public class AdGroupDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of your AdWords ad group.
		/// </summary>
		public AdGroupDimension(): base("Ad Group","The name of your AdWords ad group.",true,"ga:adGroup")
		{
			
		}
	}
}

