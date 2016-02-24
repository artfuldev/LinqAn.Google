using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of social interactions per session.
	/// </summary>
	[Description("The number of social interactions per session.")]
	public class SocialInteractionsPerSession: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialInteractionsPerSession" />.
		/// </summary>
		public SocialInteractionsPerSession(): base("Actions Per Social Session",false,"ga:socialInteractionsPerSession")
		{
			
		}
	}
}

