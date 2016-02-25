using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal1Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal1Starts" />.
		/// </summary>
		public Goal1Starts(): base("Goal 1 Starts",true,"ga:goal1Starts")
		{
			
		}
	}
}

