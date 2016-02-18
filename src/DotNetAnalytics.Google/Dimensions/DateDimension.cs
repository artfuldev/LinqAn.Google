namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The date of the session formatted as YYYYMMDD.
	/// </summary>
	public class DateDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DateDimension" />.
		/// </summary>
		public DateDimension(): base("Date","The date of the session formatted as YYYYMMDD.",false,"ga:date")
		{
			
		}
	}
}

