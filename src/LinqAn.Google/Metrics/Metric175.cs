using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 175 refers the number/index of the custom metric. Note that the data type of ga:metric175 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 175 refers the number/index of the custom metric. Note that the data type of ga:metric175 can be INTEGER, CURRENCY or TIME.")]
	public class Metric175: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric175" />.
		/// </summary>
		public Metric175(): base("Custom Metric 175 Value",true,"ga:metric175")
		{
			
		}
	}
}

