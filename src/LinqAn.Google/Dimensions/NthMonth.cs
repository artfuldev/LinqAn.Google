namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.
	/// </summary>
	public class NthMonth: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="NthMonth" />.
		/// </summary>
		public NthMonth(): base("Month Index","Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.",false,"ga:nthMonth")
		{
			
		}
	}
}

