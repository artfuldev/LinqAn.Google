using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal6Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal6Value" />.
		/// </summary>
		public Goal6Value(): base("Goal 6 Value",true,"ga:goal6Value")
		{
			
		}
	}
}

