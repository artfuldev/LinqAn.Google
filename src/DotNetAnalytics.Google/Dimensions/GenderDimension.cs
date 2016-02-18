namespace DotNetAnalytics.Google.Dimensions
{
	public class GenderDimension: Dimension<string>
	{
		/// <summary>
		/// 	Gender of user.
		/// </summary>
		public GenderDimension(): base("Gender","Gender of user.",false,"ga:userGender")
		{
			
		}
	}
}

