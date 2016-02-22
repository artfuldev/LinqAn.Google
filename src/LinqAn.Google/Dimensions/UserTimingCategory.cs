using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string for categorizing all user timing variables into logical groups for easier reporting purposes.
	/// </summary>
	[Description("A string for categorizing all user timing variables into logical groups for easier reporting purposes.")]
	public class UserTimingCategory: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserTimingCategory" />.
		/// </summary>
		public UserTimingCategory(): base("Timing Category",true,"ga:userTimingCategory")
		{
			
		}
	}
}

