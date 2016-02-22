using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Gender of user.
	/// </summary>
	[Description("Gender of user.")]
	public class UserGender: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserGender" />.
		/// </summary>
		public UserGender(): base("Gender",false,"ga:userGender")
		{
			
		}
	}
}

