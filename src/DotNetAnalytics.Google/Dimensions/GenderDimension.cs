namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Gender of user.
	/// </summary>
	public class GenderDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="GenderDimension" />.
		/// </summary>
		public GenderDimension(): base("Gender","Gender of user.",false,"ga:userGender")
		{
			
		}
	}
}

