using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal17Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal17Starts" />.
		/// </summary>
		public Goal17Starts(): base("Goal 17 Starts",true,"ga:goal17Starts")
		{
			
		}
	}
}

