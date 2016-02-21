namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The length of a session measured in seconds and reported in second increments. The value returned is a string.
	/// </summary>
	public class SessionDurationBucket: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SessionDurationBucket" />.
		/// </summary>
		public SessionDurationBucket(): base("Session Duration","The length of a session measured in seconds and reported in second increments. The value returned is a string.",true,"ga:sessionDurationBucket")
		{
			
		}
	}
}

