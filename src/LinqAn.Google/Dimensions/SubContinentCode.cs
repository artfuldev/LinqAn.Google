namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code.
	/// </summary>
	public class SubContinentCode: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SubContinentCode" />.
		/// </summary>
		public SubContinentCode(): base("Sub Continent Code","The sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code.",false,"ga:subContinentCode")
		{
			
		}
	}
}

