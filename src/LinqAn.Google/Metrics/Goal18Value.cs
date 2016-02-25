using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal18Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal18Value" />.
		/// </summary>
		public Goal18Value(): base("Goal 18 Value",true,"ga:goal18Value")
		{
			
		}
	}
}

