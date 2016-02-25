using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 164 refers the number/index of the custom metric. Note that the data type of ga:metric164 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 164 refers the number/index of the custom metric. Note that the data type of ga:metric164 can be INTEGER, CURRENCY or TIME.")]
	public class Metric164: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric164" />.
		/// </summary>
		public Metric164(): base("Custom Metric 164 Value",true,"ga:metric164")
		{
			
		}
	}
}

