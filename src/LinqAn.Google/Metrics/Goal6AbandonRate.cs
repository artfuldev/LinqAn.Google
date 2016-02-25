using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal6AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal6AbandonRate" />.
		/// </summary>
		public Goal6AbandonRate(): base("Goal 6 Abandonment Rate",false,"ga:goal6AbandonRate")
		{
			
		}
	}
}

