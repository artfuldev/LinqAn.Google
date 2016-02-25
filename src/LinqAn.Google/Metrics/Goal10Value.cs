using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal10Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal10Value" />.
		/// </summary>
		public Goal10Value(): base("Goal 10 Value",true,"ga:goal10Value")
		{
			
		}
	}
}

