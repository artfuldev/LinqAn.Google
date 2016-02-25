using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal8Value: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal8Value" />.
		/// </summary>
		public Goal8Value(): base("Goal 8 Value",true,"ga:goal8Value")
		{
			
		}
	}
}

