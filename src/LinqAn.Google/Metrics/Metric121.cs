using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 121 refers the number/index of the custom metric. Note that the data type of ga:metric121 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 121 refers the number/index of the custom metric. Note that the data type of ga:metric121 can be INTEGER, CURRENCY or TIME.")]
	public class Metric121: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric121" />.
		/// </summary>
		public Metric121(): base("Custom Metric 121 Value",true,"ga:metric121")
		{
			
		}
	}
}

