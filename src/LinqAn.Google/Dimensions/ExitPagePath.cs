namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The last page in a user's session, or exit page.
	/// </summary>
	public class ExitPagePath: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ExitPagePath" />.
		/// </summary>
		public ExitPagePath(): base("Exit Page","The last page in a user's session, or exit page.",true,"ga:exitPagePath")
		{
			
		}
	}
}

