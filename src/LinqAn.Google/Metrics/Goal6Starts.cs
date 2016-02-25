using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal6Starts: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal6Starts" />.
		/// </summary>
		public Goal6Starts(): base("Goal 6 Starts",true,"ga:goal6Starts")
		{
			
		}
	}
}

