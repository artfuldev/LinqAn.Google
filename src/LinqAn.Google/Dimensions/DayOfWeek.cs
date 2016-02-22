using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).
	/// </summary>
	[Description("The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).")]
	public class DayOfWeek: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DayOfWeek" />.
		/// </summary>
		public DayOfWeek(): base("Day of Week",false,"ga:dayOfWeek")
		{
			
		}
	}
}

