using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 133 refers the number/index of the custom metric. Note that the data type of ga:metric133 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 133 refers the number/index of the custom metric. Note that the data type of ga:metric133 can be INTEGER, CURRENCY or TIME.")]
	public class Metric133: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric133" />.
		/// </summary>
		public Metric133(): base("Custom Metric 133 Value",true,"ga:metric133")
		{
			
		}
	}
}

