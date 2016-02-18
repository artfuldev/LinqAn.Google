namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	A string for categorizing all user timing variables into logical groups for easier reporting purposes.
	/// </summary>
	public class TimingCategoryDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TimingCategoryDimension" />.
		/// </summary>
		public TimingCategoryDimension(): base("Timing Category","A string for categorizing all user timing variables into logical groups for easier reporting purposes.",true,"ga:userTimingCategory")
		{
			
		}
	}
}

