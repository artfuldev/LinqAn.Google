using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal15Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal15Value" />.
		/// </summary>
		public Goal15Value(): base("Goal 15 Value",true,"ga:goal15Value")
		{
			
		}
	}
}

