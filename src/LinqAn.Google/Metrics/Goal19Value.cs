using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal19Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal19Value" />.
		/// </summary>
		public Goal19Value(): base("Goal 19 Value",true,"ga:goal19Value")
		{
			
		}
	}
}

