using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of fatal exceptions thrown divided by the number of screenviews.
	/// </summary>
	[Description("The number of fatal exceptions thrown divided by the number of screenviews.")]
	public class FatalExceptionsPerScreenview: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="FatalExceptionsPerScreenview" />.
		/// </summary>
		public FatalExceptionsPerScreenview(): base("Crashes / Screen",false,"ga:fatalExceptionsPerScreenview")
		{
			
		}
	}
}

