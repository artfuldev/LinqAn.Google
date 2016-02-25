using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 185 refers the number/index of the custom metric. Note that the data type of ga:metric185 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 185 refers the number/index of the custom metric. Note that the data type of ga:metric185 can be INTEGER, CURRENCY or TIME.")]
	public class Metric185: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric185" />.
		/// </summary>
		public Metric185(): base("Custom Metric 185 Value",true,"ga:metric185")
		{
			
		}
	}
}

