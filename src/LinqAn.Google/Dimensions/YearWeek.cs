namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:year and ga:week.
	/// </summary>
	public class YearWeek: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="YearWeek" />.
		/// </summary>
		public YearWeek(): base("Week of Year","Combined values of ga:year and ga:week.",false,"ga:yearWeek")
		{
			
		}
	}
}

