using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 151 refers the number/index of the custom metric. Note that the data type of ga:metric151 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 151 refers the number/index of the custom metric. Note that the data type of ga:metric151 can be INTEGER, CURRENCY or TIME.")]
	public class Metric151: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric151" />.
		/// </summary>
		public Metric151(): base("Custom Metric 151 Value",true,"ga:metric151")
		{
			
		}
	}
}

