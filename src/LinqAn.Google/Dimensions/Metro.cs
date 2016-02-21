namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The Designated Market Area (DMA) from where traffic arrived.
	/// </summary>
	public class Metro: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Metro" />.
		/// </summary>
		public Metro(): base("Metro","The Designated Market Area (DMA) from where traffic arrived.",true,"ga:metro")
		{
			
		}
	}
}

