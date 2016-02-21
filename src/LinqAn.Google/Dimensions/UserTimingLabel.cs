namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the resource's action being tracked.
	/// </summary>
	public class UserTimingLabel: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserTimingLabel" />.
		/// </summary>
		public UserTimingLabel(): base("Timing Label","The name of the resource's action being tracked.",true,"ga:userTimingLabel")
		{
			
		}
	}
}

