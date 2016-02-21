namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A value that can be used to add flexibility in visualizing user timings in the reports.
	/// </summary>
	public class UserTimingVariable: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserTimingVariable" />.
		/// </summary>
		public UserTimingVariable(): base("Timing Variable","A value that can be used to add flexibility in visualizing user timings in the reports.",true,"ga:userTimingVariable")
		{
			
		}
	}
}

