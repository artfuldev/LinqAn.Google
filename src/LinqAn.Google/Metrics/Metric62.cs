using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 62 refers the number/index of the custom metric. Note that the data type of ga:metric62 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 62 refers the number/index of the custom metric. Note that the data type of ga:metric62 can be INTEGER, CURRENCY or TIME.")]
	public class Metric62: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric62" />.
		/// </summary>
		public Metric62(): base("Custom Metric 62 Value",true,"ga:metric62")
		{
			
		}
	}
}

