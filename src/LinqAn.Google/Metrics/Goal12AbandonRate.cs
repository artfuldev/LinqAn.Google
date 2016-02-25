using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal12AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal12AbandonRate" />.
		/// </summary>
		public Goal12AbandonRate(): base("Goal 12 Abandonment Rate",false,"ga:goal12AbandonRate")
		{
			
		}
	}
}

