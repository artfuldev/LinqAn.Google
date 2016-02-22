namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:source and ga:medium.
	/// </summary>
	public class SourceMedium: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SourceMedium" />.
		/// </summary>
		public SourceMedium(): base("Source / Medium","Combined values of ga:source and ga:medium.",true,"ga:sourceMedium")
		{
			
		}
	}
}

