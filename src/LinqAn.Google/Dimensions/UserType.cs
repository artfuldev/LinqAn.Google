using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.
	/// </summary>
	[Description("A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.")]
	public class UserType: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserType" />.
		/// </summary>
		public UserType(): base("User Type",true,"ga:userType")
		{
			
		}
	}
}

