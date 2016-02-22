using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:date and ga:hour.
	/// </summary>
	[Description("Combined values of ga:date and ga:hour.")]
	public class DateHour: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DateHour" />.
		/// </summary>
		public DateHour(): base("Hour of Day",false,"ga:dateHour")
		{
			
		}
	}
}

