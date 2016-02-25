using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 123 refers the number/index of the custom metric. Note that the data type of ga:metric123 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 123 refers the number/index of the custom metric. Note that the data type of ga:metric123 can be INTEGER, CURRENCY or TIME.")]
	public class Metric123: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric123" />.
		/// </summary>
		public Metric123(): base("Custom Metric 123 Value",true,"ga:metric123")
		{
			
		}
	}
}

