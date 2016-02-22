using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The second page in a user's session.
	/// </summary>
	[Description("The second page in a user's session.")]
	public class SecondPagePath: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SecondPagePath" />.
		/// </summary>
		public SecondPagePath(): base("Second Page",false,"ga:secondPagePath")
		{
			
		}
	}
}

