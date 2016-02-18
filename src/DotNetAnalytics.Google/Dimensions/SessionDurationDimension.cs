namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The length of a session measured in seconds and reported in second increments. The value returned is a string.
	/// </summary>
	public class SessionDurationDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SessionDurationDimension" />.
		/// </summary>
		public SessionDurationDimension(): base("Session Duration","The length of a session measured in seconds and reported in second increments. The value returned is a string.",true,"ga:sessionDurationBucket")
		{
			
		}
	}
}

