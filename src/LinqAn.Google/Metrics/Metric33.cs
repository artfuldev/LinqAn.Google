using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 33 refers the number/index of the custom metric. Note that the data type of ga:metric33 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 33 refers the number/index of the custom metric. Note that the data type of ga:metric33 can be INTEGER, CURRENCY or TIME.")]
	public class Metric33: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric33" />.
		/// </summary>
		public Metric33(): base("Custom Metric 33 Value",true,"ga:metric33")
		{
			
		}
	}
}

