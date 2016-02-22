using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.
	/// </summary>
	[Description("The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.")]
	public class ExperimentId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ExperimentId" />.
		/// </summary>
		public ExperimentId(): base("Experiment ID",true,"ga:experimentId")
		{
			
		}
	}
}

