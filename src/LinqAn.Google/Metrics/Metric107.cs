using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 107 refers the number/index of the custom metric. Note that the data type of ga:metric107 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 107 refers the number/index of the custom metric. Note that the data type of ga:metric107 can be INTEGER, CURRENCY or TIME.")]
	public class Metric107: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric107" />.
		/// </summary>
		public Metric107(): base("Custom Metric 107 Value",true,"ga:metric107")
		{
			
		}
	}
}

