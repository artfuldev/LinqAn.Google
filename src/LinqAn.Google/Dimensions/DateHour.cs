namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:date and ga:hour.
	/// </summary>
	public class DateHour: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DateHour" />.
		/// </summary>
		public DateHour(): base("Hour of Day","Combined values of ga:date and ga:hour.",false,"ga:dateHour")
		{
			
		}
	}
}

