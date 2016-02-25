using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal14Starts: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal14Starts" />.
		/// </summary>
		public Goal14Starts(): base("Goal 14 Starts",true,"ga:goal14Starts")
		{
			
		}
	}
}

