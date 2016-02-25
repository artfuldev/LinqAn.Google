using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal7AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal7AbandonRate" />.
		/// </summary>
		public Goal7AbandonRate(): base("Goal 7 Abandonment Rate",false,"ga:goal7AbandonRate")
		{
			
		}
	}
}

