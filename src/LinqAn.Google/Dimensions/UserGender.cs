namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Gender of user.
	/// </summary>
	public class UserGender: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserGender" />.
		/// </summary>
		public UserGender(): base("Gender","Gender of user.",false,"ga:userGender")
		{
			
		}
	}
}

