using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The week of the session. A two-digit number from 01 to 53. Each week starts on Sunday.
	/// </summary>
	[Description("The week of the session. A two-digit number from 01 to 53. Each week starts on Sunday.")]
	public class Week: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Week" />.
		/// </summary>
		public Week(): base("Week of the Year",false,"ga:week")
		{
			
		}
	}
}

