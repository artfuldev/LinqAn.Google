using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 65 refers the number/index of the custom metric. Note that the data type of ga:metric65 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 65 refers the number/index of the custom metric. Note that the data type of ga:metric65 can be INTEGER, CURRENCY or TIME.")]
	public class Metric65: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric65" />.
		/// </summary>
		public Metric65(): base("Custom Metric 65 Value",true,"ga:metric65")
		{
			
		}
	}
}

