using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 153 refers the number/index of the custom metric. Note that the data type of ga:metric153 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 153 refers the number/index of the custom metric. Note that the data type of ga:metric153 can be INTEGER, CURRENCY or TIME.")]
	public class Metric153: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric153" />.
		/// </summary>
		public Metric153(): base("Custom Metric 153 Value",true,"ga:metric153")
		{
			
		}
	}
}

