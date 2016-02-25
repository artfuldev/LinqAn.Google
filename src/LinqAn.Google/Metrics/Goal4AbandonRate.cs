using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal4AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal4AbandonRate" />.
		/// </summary>
		public Goal4AbandonRate(): base("Goal 4 Abandonment Rate",false,"ga:goal4AbandonRate")
		{
			
		}
	}
}

