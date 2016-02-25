using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 143 refers the number/index of the custom metric. Note that the data type of ga:metric143 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 143 refers the number/index of the custom metric. Note that the data type of ga:metric143 can be INTEGER, CURRENCY or TIME.")]
	public class Metric143: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric143" />.
		/// </summary>
		public Metric143(): base("Custom Metric 143 Value",true,"ga:metric143")
		{
			
		}
	}
}

