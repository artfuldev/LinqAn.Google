using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal15AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal15AbandonRate" />.
		/// </summary>
		public Goal15AbandonRate(): base("Goal 15 Abandonment Rate",false,"ga:goal15AbandonRate")
		{
			
		}
	}
}

