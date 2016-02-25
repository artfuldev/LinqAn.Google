using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal14AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal14AbandonRate" />.
		/// </summary>
		public Goal14AbandonRate(): base("Goal 14 Abandonment Rate",false,"ga:goal14AbandonRate")
		{
			
		}
	}
}

