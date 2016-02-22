using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The date of the session formatted as YYYYMMDD.
	/// </summary>
	[Description("The date of the session formatted as YYYYMMDD.")]
	public class Date: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Date" />.
		/// </summary>
		public Date(): base("Date",false,"ga:date")
		{
			
		}
	}
}

