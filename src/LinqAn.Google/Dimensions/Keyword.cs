using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	When using manual campaign tracking, the value of the utm_term campaign tracking parameter. When using AdWords autotagging or if a user used organic search to reach your property, the keywords used by users to reach your property. Otherwise the value is (not set).
	/// </summary>
	[Description("When using manual campaign tracking, the value of the utm_term campaign tracking parameter. When using AdWords autotagging or if a user used organic search to reach your property, the keywords used by users to reach your property. Otherwise the value is (not set).")]
	public class Keyword: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Keyword" />.
		/// </summary>
		public Keyword(): base("Keyword",true,"ga:keyword")
		{
			
		}
	}
}

