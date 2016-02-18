namespace DotNetAnalytics.Google.Dimensions
{
	public class UserDefinedValueDimension: Dimension<string>
	{
		/// <summary>
		/// 	The value provided when you define custom user segments for your property.
		/// </summary>
		public UserDefinedValueDimension(): base("User Defined Value","The value provided when you define custom user segments for your property.",true,"ga:userDefinedValue")
		{
			
		}
	}
}

