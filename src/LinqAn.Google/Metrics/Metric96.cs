using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 96 refers the number/index of the custom metric. Note that the data type of ga:metric96 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 96 refers the number/index of the custom metric. Note that the data type of ga:metric96 can be INTEGER, CURRENCY or TIME.")]
	public class Metric96: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric96" />.
		/// </summary>
		public Metric96(): base("Custom Metric 96 Value",true,"ga:metric96")
		{
			
		}
	}
}

