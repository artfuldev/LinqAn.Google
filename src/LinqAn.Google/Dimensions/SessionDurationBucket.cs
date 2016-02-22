using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The length of a session measured in seconds and reported in second increments. The value returned is a string.
	/// </summary>
	[Description("The length of a session measured in seconds and reported in second increments. The value returned is a string.")]
	public class SessionDurationBucket: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SessionDurationBucket" />.
		/// </summary>
		public SessionDurationBucket(): base("Session Duration",true,"ga:sessionDurationBucket")
		{
			
		}
	}
}

