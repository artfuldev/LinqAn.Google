using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 170 refers the number/index of the custom metric. Note that the data type of ga:metric170 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 170 refers the number/index of the custom metric. Note that the data type of ga:metric170 can be INTEGER, CURRENCY or TIME.")]
	public class Metric170: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric170" />.
		/// </summary>
		public Metric170(): base("Custom Metric 170 Value",true,"ga:metric170")
		{
			
		}
	}
}

