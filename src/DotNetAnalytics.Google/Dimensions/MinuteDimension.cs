namespace DotNetAnalytics.Google.Dimensions
{
	public class MinuteDimension: Dimension<string>
	{
		/// <summary>
		/// 	Returns the minute in the hour. The possible values are between 00 and 59.
		/// </summary>
		public MinuteDimension(): base("Minute","Returns the minute in the hour. The possible values are between 00 and 59.",true,"ga:minute")
		{
			
		}
	}
}

