using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 97 refers the number/index of the custom metric. Note that the data type of ga:metric97 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 97 refers the number/index of the custom metric. Note that the data type of ga:metric97 can be INTEGER, CURRENCY or TIME.")]
	public class Metric97: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric97" />.
		/// </summary>
		public Metric97(): base("Custom Metric 97 Value",true,"ga:metric97")
		{
			
		}
	}
}

