using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 102 refers the number/index of the custom metric. Note that the data type of ga:metric102 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 102 refers the number/index of the custom metric. Note that the data type of ga:metric102 can be INTEGER, CURRENCY or TIME.")]
	public class Metric102: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric102" />.
		/// </summary>
		public Metric102(): base("Custom Metric 102 Value",true,"ga:metric102")
		{
			
		}
	}
}

