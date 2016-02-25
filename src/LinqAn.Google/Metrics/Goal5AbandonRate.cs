using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal5AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal5AbandonRate" />.
		/// </summary>
		public Goal5AbandonRate(): base("Goal 5 Abandonment Rate",false,"ga:goal5AbandonRate")
		{
			
		}
	}
}

