namespace DotNetAnalytics.Google.Dimensions
{
	public class SessionDurationDimension: Dimension<string>
	{
		/// <summary>
		/// 	The length of a session measured in seconds and reported in second increments. The value returned is a string.
		/// </summary>
		public SessionDurationDimension(): base("Session Duration","The length of a session measured in seconds and reported in second increments. The value returned is a string.",true,"ga:sessionDurationBucket")
		{
			
		}
	}
}

