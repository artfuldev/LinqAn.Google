using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal10Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal10Starts" />.
		/// </summary>
		public Goal10Starts(): base("Goal 10 Starts",true,"ga:goal10Starts")
		{
			
		}
	}
}

