using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average value of an event.
	/// </summary>
	[Description("The average value of an event.")]
	public class AvgEventValue: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgEventValue" />.
		/// </summary>
		public AvgEventValue(): base("Avg. Value",false,"ga:avgEventValue")
		{
			
		}
	}
}

