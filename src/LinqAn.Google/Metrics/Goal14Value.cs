using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal14Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal14Value" />.
		/// </summary>
		public Goal14Value(): base("Goal 14 Value",true,"ga:goal14Value")
		{
			
		}
	}
}

