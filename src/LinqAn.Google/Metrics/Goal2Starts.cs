using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal2Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal2Starts" />.
		/// </summary>
		public Goal2Starts(): base("Goal 2 Starts",true,"ga:goal2Starts")
		{
			
		}
	}
}

