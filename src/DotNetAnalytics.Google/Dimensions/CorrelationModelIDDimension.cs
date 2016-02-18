namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Correlation Model ID for related products.
	/// </summary>
	public class CorrelationModelIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="CorrelationModelIDDimension" />.
		/// </summary>
		public CorrelationModelIDDimension(): base("Correlation Model ID","Correlation Model ID for related products.",false,"ga:correlationModelId")
		{
			
		}
	}
}

