using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 155 refers the number/index of the custom metric. Note that the data type of ga:metric155 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 155 refers the number/index of the custom metric. Note that the data type of ga:metric155 can be INTEGER, CURRENCY or TIME.")]
	public class Metric155: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric155" />.
		/// </summary>
		public Metric155(): base("Custom Metric 155 Value",true,"ga:metric155")
		{
			
		}
	}
}

