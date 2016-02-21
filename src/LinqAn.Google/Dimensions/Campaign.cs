namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	When using manual campaign tracking, the value of the utm_campaign campaign tracking parameter. When using AdWords autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the value (not set) is used.
	/// </summary>
	public class Campaign: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Campaign" />.
		/// </summary>
		public Campaign(): base("Campaign","When using manual campaign tracking, the value of the utm_campaign campaign tracking parameter. When using AdWords autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the value (not set) is used.",true,"ga:campaign")
		{
			
		}
	}
}

