namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The description for the exception.
	/// </summary>
	public class ExceptionDescriptionDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ExceptionDescriptionDimension" />.
		/// </summary>
		public ExceptionDescriptionDimension(): base("Exception Description","The description for the exception.",true,"ga:exceptionDescription")
		{
			
		}
	}
}

