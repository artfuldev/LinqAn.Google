using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:year and ga:month.
	/// </summary>
	[Description("Combined values of ga:year and ga:month.")]
	public class YearMonth: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="YearMonth" />.
		/// </summary>
		public YearMonth(): base("Month of Year",false,"ga:yearMonth")
		{
			
		}
	}
}

