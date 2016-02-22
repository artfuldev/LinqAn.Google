namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:year and ga:month.
	/// </summary>
	public class YearMonth: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="YearMonth" />.
		/// </summary>
		public YearMonth(): base("Month of Year","Combined values of ga:year and ga:month.",false,"ga:yearMonth")
		{
			
		}
	}
}

