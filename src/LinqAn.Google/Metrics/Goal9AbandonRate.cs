using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal9AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal9AbandonRate" />.
		/// </summary>
		public Goal9AbandonRate(): base("Goal 9 Abandonment Rate",false,"ga:goal9AbandonRate")
		{
			
		}
	}
}

