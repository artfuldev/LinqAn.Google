using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the day of the week (in English).
	/// </summary>
	[Description("The name of the day of the week (in English).")]
	public class DayOfWeekName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DayOfWeekName" />.
		/// </summary>
		public DayOfWeekName(): base("Day of Week Name",false,"ga:dayOfWeekName")
		{
			
		}
	}
}

