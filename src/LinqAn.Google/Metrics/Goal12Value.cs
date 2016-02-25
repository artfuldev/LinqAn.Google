using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal12Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal12Value" />.
		/// </summary>
		public Goal12Value(): base("Goal 12 Value",true,"ga:goal12Value")
		{
			
		}
	}
}

