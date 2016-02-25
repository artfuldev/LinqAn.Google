using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 171 refers the number/index of the custom metric. Note that the data type of ga:metric171 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 171 refers the number/index of the custom metric. Note that the data type of ga:metric171 can be INTEGER, CURRENCY or TIME.")]
	public class Metric171: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric171" />.
		/// </summary>
		public Metric171(): base("Custom Metric 171 Value",true,"ga:metric171")
		{
			
		}
	}
}

