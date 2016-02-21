namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.
	/// </summary>
	public class UserType: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="UserType" />.
		/// </summary>
		public UserType(): base("User Type","A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.",true,"ga:userType")
		{
			
		}
	}
}

