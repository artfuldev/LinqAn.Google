namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The user-scoped id of the particular variation that the user was exposed to during a content experiment.
	/// </summary>
	public class ExperimentVariant: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ExperimentVariant" />.
		/// </summary>
		public ExperimentVariant(): base("Variation","The user-scoped id of the particular variation that the user was exposed to during a content experiment.",true,"ga:experimentVariant")
		{
			
		}
	}
}

