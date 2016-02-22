using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:year and ga:week.
	/// </summary>
	[Description("Combined values of ga:year and ga:week.")]
	public class YearWeek: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="YearWeek" />.
		/// </summary>
		public YearWeek(): base("Week of Year",false,"ga:yearWeek")
		{
			
		}
	}
}

