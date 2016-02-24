using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exceptions thrown divided by the number of screenviews.
	/// </summary>
	[Description("The number of exceptions thrown divided by the number of screenviews.")]
	public class ExceptionsPerScreenview: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ExceptionsPerScreenview" />.
		/// </summary>
		public ExceptionsPerScreenview(): base("Exceptions / Screen",false,"ga:exceptionsPerScreenview")
		{
			
		}
	}
}

