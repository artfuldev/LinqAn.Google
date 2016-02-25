using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal13AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal13AbandonRate" />.
		/// </summary>
		public Goal13AbandonRate(): base("Goal 13 Abandonment Rate",false,"ga:goal13AbandonRate")
		{
			
		}
	}
}

