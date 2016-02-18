namespace DotNetAnalytics.Google.Dimensions
{
	public class SubContinentDimension: Dimension<string>
	{
		/// <summary>
		/// 	The sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe.
		/// </summary>
		public SubContinentDimension(): base("Sub Continent","The sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe.",true,"ga:subContinent")
		{
			
		}
	}
}

