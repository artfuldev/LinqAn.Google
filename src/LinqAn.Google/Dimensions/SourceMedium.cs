using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:source and ga:medium.
	/// </summary>
	[Description("Combined values of ga:source and ga:medium.")]
	public class SourceMedium: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SourceMedium" />.
		/// </summary>
		public SourceMedium(): base("Source / Medium",true,"ga:sourceMedium")
		{
			
		}
	}
}

