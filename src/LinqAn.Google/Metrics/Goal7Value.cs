using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal7Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal7Value" />.
		/// </summary>
		public Goal7Value(): base("Goal 7 Value",true,"ga:goal7Value")
		{
			
		}
	}
}

