using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for the requested goal number.
	/// </summary>
	[Description("The total numeric value for the requested goal number.")]
	public class Goal3Value: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal3Value" />.
		/// </summary>
		public Goal3Value(): base("Goal 3 Value",true,"ga:goal3Value")
		{
			
		}
	}
}

