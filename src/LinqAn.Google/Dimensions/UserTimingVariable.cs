using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A value that can be used to add flexibility in visualizing user timings in the reports.
	/// </summary>
	[Description("A value that can be used to add flexibility in visualizing user timings in the reports.")]
	public class UserTimingVariable: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserTimingVariable" />.
		/// </summary>
		public UserTimingVariable(): base("Timing Variable",true,"ga:userTimingVariable")
		{
			
		}
	}
}

