using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 166 refers the number/index of the custom metric. Note that the data type of ga:metric166 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 166 refers the number/index of the custom metric. Note that the data type of ga:metric166 can be INTEGER, CURRENCY or TIME.")]
	public class Metric166: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric166" />.
		/// </summary>
		public Metric166(): base("Custom Metric 166 Value",true,"ga:metric166")
		{
			
		}
	}
}

