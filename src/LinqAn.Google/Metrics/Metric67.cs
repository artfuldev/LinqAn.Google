using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 67 refers the number/index of the custom metric. Note that the data type of ga:metric67 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 67 refers the number/index of the custom metric. Note that the data type of ga:metric67 can be INTEGER, CURRENCY or TIME.")]
	public class Metric67: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric67" />.
		/// </summary>
		public Metric67(): base("Custom Metric 67 Value",true,"ga:metric67")
		{
			
		}
	}
}

