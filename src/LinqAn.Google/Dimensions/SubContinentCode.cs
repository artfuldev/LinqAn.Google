using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code.
	/// </summary>
	[Description("The sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code.")]
	public class SubContinentCode: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SubContinentCode" />.
		/// </summary>
		public SubContinentCode(): base("Sub Continent Code",false,"ga:subContinentCode")
		{
			
		}
	}
}

