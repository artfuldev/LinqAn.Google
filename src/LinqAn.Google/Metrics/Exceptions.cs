namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exceptions that were sent to Google Analytics.
	/// </summary>
	public class Exceptions: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Exceptions" />.
		/// </summary>
		public Exceptions(): base("Exceptions","The number of exceptions that were sent to Google Analytics.",true,"ga:exceptions")
		{
			
		}
	}
}

