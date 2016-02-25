using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 174 refers the number/index of the custom metric. Note that the data type of ga:metric174 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 174 refers the number/index of the custom metric. Note that the data type of ga:metric174 can be INTEGER, CURRENCY or TIME.")]
	public class Metric174: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric174" />.
		/// </summary>
		public Metric174(): base("Custom Metric 174 Value",true,"ga:metric174")
		{
			
		}
	}
}

