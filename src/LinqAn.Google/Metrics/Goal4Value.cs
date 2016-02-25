using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal4Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal4Value" />.
		/// </summary>
		public Goal4Value(): base("Goal 4 Value",true,"ga:goal4Value")
		{
			
		}
	}
}

