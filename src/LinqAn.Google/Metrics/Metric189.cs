using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 189 refers the number/index of the custom metric. Note that the data type of ga:metric189 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 189 refers the number/index of the custom metric. Note that the data type of ga:metric189 can be INTEGER, CURRENCY or TIME.")]
	public class Metric189: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric189" />.
		/// </summary>
		public Metric189(): base("Custom Metric 189 Value",true,"ga:metric189")
		{
			
		}
	}
}

