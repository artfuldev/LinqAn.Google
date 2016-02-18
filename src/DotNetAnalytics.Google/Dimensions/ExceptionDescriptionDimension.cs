namespace DotNetAnalytics.Google.Dimensions
{
	public class ExceptionDescriptionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The description for the exception.
		/// </summary>
		public ExceptionDescriptionDimension(): base("Exception Description","The description for the exception.",true,"ga:exceptionDescription")
		{
			
		}
	}
}

