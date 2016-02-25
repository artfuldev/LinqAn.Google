using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal20Starts: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal20Starts" />.
		/// </summary>
		public Goal20Starts(): base("Goal 20 Starts",true,"ga:goal20Starts")
		{
			
		}
	}
}

