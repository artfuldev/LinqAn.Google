using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal11AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal11AbandonRate" />.
		/// </summary>
		public Goal11AbandonRate(): base("Goal 11 Abandonment Rate",false,"ga:goal11AbandonRate")
		{
			
		}
	}
}

