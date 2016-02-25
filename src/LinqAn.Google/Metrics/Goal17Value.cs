using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal17Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal17Value" />.
		/// </summary>
		public Goal17Value(): base("Goal 17 Value",true,"ga:goal17Value")
		{
			
		}
	}
}

