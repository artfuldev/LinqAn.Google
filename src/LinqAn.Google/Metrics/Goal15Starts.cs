using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal15Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal15Starts" />.
		/// </summary>
		public Goal15Starts(): base("Goal 15 Starts",true,"ga:goal15Starts")
		{
			
		}
	}
}

