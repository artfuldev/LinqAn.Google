using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal16Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal16Value" />.
		/// </summary>
		public Goal16Value(): base("Goal 16 Value",true,"ga:goal16Value")
		{
			
		}
	}
}

