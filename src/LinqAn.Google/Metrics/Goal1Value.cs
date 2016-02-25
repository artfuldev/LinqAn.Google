using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal1Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal1Value" />.
		/// </summary>
		public Goal1Value(): base("Goal 1 Value",true,"ga:goal1Value")
		{
			
		}
	}
}

