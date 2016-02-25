using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal9Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal9Value" />.
		/// </summary>
		public Goal9Value(): base("Goal 9 Value",true,"ga:goal9Value")
		{
			
		}
	}
}

