namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.
	/// </summary>
	public class ExperimentId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ExperimentId" />.
		/// </summary>
		public ExperimentId(): base("Experiment ID","The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.",true,"ga:experimentId")
		{
			
		}
	}
}

