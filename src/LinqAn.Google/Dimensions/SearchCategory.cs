namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The categories used for the internal search if you have this enabled for your profile. For example, you might have product categories such as electronics, furniture, or clothing.
	/// </summary>
	public class SearchCategory: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SearchCategory" />.
		/// </summary>
		public SearchCategory(): base("Site Search Category","The categories used for the internal search if you have this enabled for your profile. For example, you might have product categories such as electronics, furniture, or clothing.",true,"ga:searchCategory")
		{
			
		}
	}
}

