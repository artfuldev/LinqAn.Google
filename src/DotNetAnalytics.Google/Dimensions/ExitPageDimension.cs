namespace DotNetAnalytics.Google.Dimensions
{
	public class ExitPageDimension: Dimension<string>
	{
		/// <summary>
		/// 	The last page in a user's session, or exit page.
		/// </summary>
		public ExitPageDimension(): base("Exit Page","The last page in a user's session, or exit page.",true,"ga:exitPagePath")
		{
			
		}
	}
}

