using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal11Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal11Value" />.
		/// </summary>
		public Goal11Value(): base("Goal 11 Value",true,"ga:goal11Value")
		{
			
		}
	}
}

