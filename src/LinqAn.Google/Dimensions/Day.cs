using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The day of the month. A two-digit number from 01 to 31.
	/// </summary>
	[Description("The day of the month. A two-digit number from 01 to 31.")]
	public class Day: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Day" />.
		/// </summary>
		public Day(): base("Day of the month",false,"ga:day")
		{
			
		}
	}
}

