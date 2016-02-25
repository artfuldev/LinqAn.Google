using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal3Starts: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal3Starts" />.
		/// </summary>
		public Goal3Starts(): base("Goal 3 Starts",true,"ga:goal3Starts")
		{
			
		}
	}
}

