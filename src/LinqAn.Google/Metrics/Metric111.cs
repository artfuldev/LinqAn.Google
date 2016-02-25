using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 111 refers the number/index of the custom metric. Note that the data type of ga:metric111 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 111 refers the number/index of the custom metric. Note that the data type of ga:metric111 can be INTEGER, CURRENCY or TIME.")]
	public class Metric111: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric111" />.
		/// </summary>
		public Metric111(): base("Custom Metric 111 Value",true,"ga:metric111")
		{
			
		}
	}
}

