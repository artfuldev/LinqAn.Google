namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The date of the session formatted as YYYYMMDD.
	/// </summary>
	public class Date: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Date" />.
		/// </summary>
		public Date(): base("Date","The date of the session formatted as YYYYMMDD.",false,"ga:date")
		{
			
		}
	}
}

