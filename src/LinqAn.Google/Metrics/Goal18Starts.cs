using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal18Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal18Starts" />.
		/// </summary>
		public Goal18Starts(): base("Goal 18 Starts",true,"ga:goal18Starts")
		{
			
		}
	}
}

