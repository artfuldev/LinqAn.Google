namespace DotNetAnalytics.Google.Dimensions
{
	public class UserTypeDimension: Dimension<string>
	{
		/// <summary>
		/// 	A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.
		/// </summary>
		public UserTypeDimension(): base("User Type","A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.",true,"ga:userType")
		{
			
		}
	}
}

