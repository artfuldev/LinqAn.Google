using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal16AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal16AbandonRate" />.
		/// </summary>
		public Goal16AbandonRate(): base("Goal 16 Abandonment Rate",false,"ga:goal16AbandonRate")
		{
			
		}
	}
}

