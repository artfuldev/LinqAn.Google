using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal5Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal5Value" />.
		/// </summary>
		public Goal5Value(): base("Goal 5 Value",true,"ga:goal5Value")
		{
			
		}
	}
}

