namespace DotNetAnalytics.Google.Dimensions
{
	public class CorrelationModelIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	Correlation Model ID for related products.
		/// </summary>
		public CorrelationModelIDDimension(): base("Correlation Model ID","Correlation Model ID for related products.",false,"ga:correlationModelId")
		{
			
		}
	}
}

