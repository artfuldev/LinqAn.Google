namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of your AdWords ad group.
	/// </summary>
	public class AdGroup: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdGroup" />.
		/// </summary>
		public AdGroup(): base("Ad Group","The name of your AdWords ad group.",true,"ga:adGroup")
		{
			
		}
	}
}

