using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal7Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal7Starts" />.
		/// </summary>
		public Goal7Starts(): base("Goal 7 Starts",true,"ga:goal7Starts")
		{
			
		}
	}
}

