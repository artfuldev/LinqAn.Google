namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string for categorizing all user timing variables into logical groups for easier reporting purposes.
	/// </summary>
	public class UserTimingCategory: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="UserTimingCategory" />.
		/// </summary>
		public UserTimingCategory(): base("Timing Category","A string for categorizing all user timing variables into logical groups for easier reporting purposes.",true,"ga:userTimingCategory")
		{
			
		}
	}
}

