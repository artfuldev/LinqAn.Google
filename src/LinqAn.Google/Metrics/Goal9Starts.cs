using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal9Starts: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal9Starts" />.
		/// </summary>
		public Goal9Starts(): base("Goal 9 Starts",true,"ga:goal9Starts")
		{
			
		}
	}
}

