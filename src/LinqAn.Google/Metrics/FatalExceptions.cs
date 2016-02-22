using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exceptions where isFatal is set to true.
	/// </summary>
	[Description("The number of exceptions where isFatal is set to true.")]
	public class FatalExceptions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="FatalExceptions" />.
		/// </summary>
		public FatalExceptions(): base("Crashes",true,"ga:fatalExceptions")
		{
			
		}
	}
}

