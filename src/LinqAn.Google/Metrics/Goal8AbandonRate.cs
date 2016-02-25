using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal8AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal8AbandonRate" />.
		/// </summary>
		public Goal8AbandonRate(): base("Goal 8 Abandonment Rate",false,"ga:goal8AbandonRate")
		{
			
		}
	}
}

