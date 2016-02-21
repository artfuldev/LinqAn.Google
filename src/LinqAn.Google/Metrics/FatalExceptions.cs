namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exceptions where isFatal is set to true.
	/// </summary>
	public class FatalExceptions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="FatalExceptions" />.
		/// </summary>
		public FatalExceptions(): base("Crashes","The number of exceptions where isFatal is set to true.",true,"ga:fatalExceptions")
		{
			
		}
	}
}

