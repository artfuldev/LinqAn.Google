using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal10AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal10AbandonRate" />.
		/// </summary>
		public Goal10AbandonRate(): base("Goal 10 Abandonment Rate",false,"ga:goal10AbandonRate")
		{
			
		}
	}
}

