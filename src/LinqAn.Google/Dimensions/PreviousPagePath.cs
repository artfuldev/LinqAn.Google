using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A page that was visited before another page on the same property. Typically used with the pagePath dimension.
	/// </summary>
	[Description("A page that was visited before another page on the same property. Typically used with the pagePath dimension.")]
	public class PreviousPagePath: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PreviousPagePath" />.
		/// </summary>
		public PreviousPagePath(): base("Previous Page Path",false,"ga:previousPagePath")
		{
			
		}
	}
}

