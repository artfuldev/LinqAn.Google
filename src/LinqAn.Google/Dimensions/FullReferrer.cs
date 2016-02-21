namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The full referring URL including the hostname and path.
	/// </summary>
	public class FullReferrer: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="FullReferrer" />.
		/// </summary>
		public FullReferrer(): base("Full Referrer","The full referring URL including the hostname and path.",false,"ga:fullReferrer")
		{
			
		}
	}
}

