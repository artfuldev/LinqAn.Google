using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal13Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal13Value" />.
		/// </summary>
		public Goal13Value(): base("Goal 13 Value",true,"ga:goal13Value")
		{
			
		}
	}
}

