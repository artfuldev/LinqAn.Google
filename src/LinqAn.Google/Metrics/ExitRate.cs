using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of exits from your property that occurred out of the total page views.
	/// </summary>
	[Description("The percentage of exits from your property that occurred out of the total page views.")]
	public class ExitRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ExitRate" />.
		/// </summary>
		public ExitRate(): base("% Exit",false,"ga:exitRate")
		{
			
		}
	}
}

