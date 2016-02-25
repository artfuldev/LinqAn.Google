using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal20AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal20AbandonRate" />.
		/// </summary>
		public Goal20AbandonRate(): base("Goal 20 Abandonment Rate",false,"ga:goal20AbandonRate")
		{
			
		}
	}
}

