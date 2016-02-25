using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 81 refers the number/index of the custom metric. Note that the data type of ga:metric81 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 81 refers the number/index of the custom metric. Note that the data type of ga:metric81 can be INTEGER, CURRENCY or TIME.")]
	public class Metric81: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric81" />.
		/// </summary>
		public Metric81(): base("Custom Metric 81 Value",true,"ga:metric81")
		{
			
		}
	}
}

