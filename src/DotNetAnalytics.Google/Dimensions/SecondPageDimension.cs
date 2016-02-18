namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The second page in a user's session.
	/// </summary>
	public class SecondPageDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SecondPageDimension" />.
		/// </summary>
		public SecondPageDimension(): base("Second Page","The second page in a user's session.",false,"ga:secondPagePath")
		{
			
		}
	}
}

