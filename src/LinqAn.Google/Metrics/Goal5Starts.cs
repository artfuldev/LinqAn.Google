using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal5Starts: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal5Starts" />.
		/// </summary>
		public Goal5Starts(): base("Goal 5 Starts",true,"ga:goal5Starts")
		{
			
		}
	}
}

