using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal2AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal2AbandonRate" />.
		/// </summary>
		public Goal2AbandonRate(): base("Goal 2 Abandonment Rate",false,"ga:goal2AbandonRate")
		{
			
		}
	}
}

