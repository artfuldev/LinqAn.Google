using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal19AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal19AbandonRate" />.
		/// </summary>
		public Goal19AbandonRate(): base("Goal 19 Abandonment Rate",false,"ga:goal19AbandonRate")
		{
			
		}
	}
}

