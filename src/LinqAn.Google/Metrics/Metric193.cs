using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 193 refers the number/index of the custom metric. Note that the data type of ga:metric193 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 193 refers the number/index of the custom metric. Note that the data type of ga:metric193 can be INTEGER, CURRENCY or TIME.")]
	public class Metric193: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric193" />.
		/// </summary>
		public Metric193(): base("Custom Metric 193 Value",true,"ga:metric193")
		{
			
		}
	}
}

