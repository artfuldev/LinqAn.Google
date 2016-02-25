using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal11Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal11Starts" />.
		/// </summary>
		public Goal11Starts(): base("Goal 11 Starts",true,"ga:goal11Starts")
		{
			
		}
	}
}

