using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The last page in a user's session, or exit page.
	/// </summary>
	[Description("The last page in a user's session, or exit page.")]
	public class ExitPagePath: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ExitPagePath" />.
		/// </summary>
		public ExitPagePath(): base("Exit Page",true,"ga:exitPagePath")
		{
			
		}
	}
}

