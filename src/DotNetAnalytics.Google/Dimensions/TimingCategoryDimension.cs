namespace DotNetAnalytics.Google.Dimensions
{
	public class TimingCategoryDimension: Dimension<string>
	{
		/// <summary>
		/// 	A string for categorizing all user timing variables into logical groups for easier reporting purposes.
		/// </summary>
		public TimingCategoryDimension(): base("Timing Category","A string for categorizing all user timing variables into logical groups for easier reporting purposes.",true,"ga:userTimingCategory")
		{
			
		}
	}
}

