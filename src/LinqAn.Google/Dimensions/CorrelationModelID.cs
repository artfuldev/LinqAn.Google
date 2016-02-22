using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Correlation Model ID for related products.
	/// </summary>
	[Description("Correlation Model ID for related products.")]
	public class CorrelationModelId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CorrelationModelId" />.
		/// </summary>
		public CorrelationModelId(): base("Correlation Model ID",false,"ga:correlationModelId")
		{
			
		}
	}
}

