using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 8 refers the number/index of the custom metric. Note that the data type of ga:metric8 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 8 refers the number/index of the custom metric. Note that the data type of ga:metric8 can be INTEGER, CURRENCY or TIME.")]
	public class Metric8: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric8" />.
		/// </summary>
		public Metric8(): base("Custom Metric 8 Value",true,"ga:metric8")
		{
			
		}
	}
}

