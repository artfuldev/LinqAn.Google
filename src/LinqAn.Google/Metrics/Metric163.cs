using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 163 refers the number/index of the custom metric. Note that the data type of ga:metric163 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 163 refers the number/index of the custom metric. Note that the data type of ga:metric163 can be INTEGER, CURRENCY or TIME.")]
	public class Metric163: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric163" />.
		/// </summary>
		public Metric163(): base("Custom Metric 163 Value",true,"ga:metric163")
		{
			
		}
	}
}

