using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal20Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal20Value" />.
		/// </summary>
		public Goal20Value(): base("Goal 20 Value",true,"ga:goal20Value")
		{
			
		}
	}
}

