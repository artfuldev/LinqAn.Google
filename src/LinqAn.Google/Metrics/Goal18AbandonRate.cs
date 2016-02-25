using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal18AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal18AbandonRate" />.
		/// </summary>
		public Goal18AbandonRate(): base("Goal 18 Abandonment Rate",false,"ga:goal18AbandonRate")
		{
			
		}
	}
}

