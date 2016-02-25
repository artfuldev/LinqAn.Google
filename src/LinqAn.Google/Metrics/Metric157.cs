using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 157 refers the number/index of the custom metric. Note that the data type of ga:metric157 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 157 refers the number/index of the custom metric. Note that the data type of ga:metric157 can be INTEGER, CURRENCY or TIME.")]
	public class Metric157: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric157" />.
		/// </summary>
		public Metric157(): base("Custom Metric 157 Value",true,"ga:metric157")
		{
			
		}
	}
}

