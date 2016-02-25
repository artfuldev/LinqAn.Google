using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 152 refers the number/index of the custom metric. Note that the data type of ga:metric152 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 152 refers the number/index of the custom metric. Note that the data type of ga:metric152 can be INTEGER, CURRENCY or TIME.")]
	public class Metric152: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric152" />.
		/// </summary>
		public Metric152(): base("Custom Metric 152 Value",true,"ga:metric152")
		{
			
		}
	}
}

