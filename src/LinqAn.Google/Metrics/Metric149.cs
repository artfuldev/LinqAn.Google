using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 149 refers the number/index of the custom metric. Note that the data type of ga:metric149 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 149 refers the number/index of the custom metric. Note that the data type of ga:metric149 can be INTEGER, CURRENCY or TIME.")]
	public class Metric149: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric149" />.
		/// </summary>
		public Metric149(): base("Custom Metric 149 Value",true,"ga:metric149")
		{
			
		}
	}
}

