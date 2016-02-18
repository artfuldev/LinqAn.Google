namespace DotNetAnalytics.Google.Dimensions
{
	public class SubContinentCodeDimension: Dimension<string>
	{
		/// <summary>
		/// 	The sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code.
		/// </summary>
		public SubContinentCodeDimension(): base("Sub Continent Code","The sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code.",false,"ga:subContinentCode")
		{
			
		}
	}
}

