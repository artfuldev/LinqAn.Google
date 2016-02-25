using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 148 refers the number/index of the custom metric. Note that the data type of ga:metric148 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 148 refers the number/index of the custom metric. Note that the data type of ga:metric148 can be INTEGER, CURRENCY or TIME.")]
	public class Metric148: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric148" />.
		/// </summary>
		public Metric148(): base("Custom Metric 148 Value",true,"ga:metric148")
		{
			
		}
	}
}

