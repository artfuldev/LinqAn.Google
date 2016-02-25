using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal3AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal3AbandonRate" />.
		/// </summary>
		public Goal3AbandonRate(): base("Goal 3 Abandonment Rate",false,"ga:goal3AbandonRate")
		{
			
		}
	}
}

