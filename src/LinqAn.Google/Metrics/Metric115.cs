using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 115 refers the number/index of the custom metric. Note that the data type of ga:metric115 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 115 refers the number/index of the custom metric. Note that the data type of ga:metric115 can be INTEGER, CURRENCY or TIME.")]
	public class Metric115: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric115" />.
		/// </summary>
		public Metric115(): base("Custom Metric 115 Value",true,"ga:metric115")
		{
			
		}
	}
}

