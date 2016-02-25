using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal2Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal2Value" />.
		/// </summary>
		public Goal2Value(): base("Goal 2 Value",true,"ga:goal2Value")
		{
			
		}
	}
}

