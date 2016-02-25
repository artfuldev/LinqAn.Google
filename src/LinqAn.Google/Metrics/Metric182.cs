using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 182 refers the number/index of the custom metric. Note that the data type of ga:metric182 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 182 refers the number/index of the custom metric. Note that the data type of ga:metric182 can be INTEGER, CURRENCY or TIME.")]
	public class Metric182: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric182" />.
		/// </summary>
		public Metric182(): base("Custom Metric 182 Value",true,"ga:metric182")
		{
			
		}
	}
}

