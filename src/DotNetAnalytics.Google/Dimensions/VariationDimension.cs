namespace DotNetAnalytics.Google.Dimensions
{
	public class VariationDimension: Dimension<string>
	{
		/// <summary>
		/// 	The user-scoped id of the particular variation that the user was exposed to during a content experiment.
		/// </summary>
		public VariationDimension(): base("Variation","The user-scoped id of the particular variation that the user was exposed to during a content experiment.",true,"ga:experimentVariant")
		{
			
		}
	}
}

