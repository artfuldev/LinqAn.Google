using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exceptions that were sent to Google Analytics.
	/// </summary>
	[Description("The number of exceptions that were sent to Google Analytics.")]
	public class Exceptions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Exceptions" />.
		/// </summary>
		public Exceptions(): base("Exceptions",true,"ga:exceptions")
		{
			
		}
	}
}

