using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal1AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal1AbandonRate" />.
		/// </summary>
		public Goal1AbandonRate(): base("Goal 1 Abandonment Rate",false,"ga:goal1AbandonRate")
		{
			
		}
	}
}

