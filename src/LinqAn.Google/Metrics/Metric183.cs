using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 183 refers the number/index of the custom metric. Note that the data type of ga:metric183 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 183 refers the number/index of the custom metric. Note that the data type of ga:metric183 can be INTEGER, CURRENCY or TIME.")]
	public class Metric183: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric183" />.
		/// </summary>
		public Metric183(): base("Custom Metric 183 Value",true,"ga:metric183")
		{
			
		}
	}
}

