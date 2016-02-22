using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The Designated Market Area (DMA) from where traffic arrived.
	/// </summary>
	[Description("The Designated Market Area (DMA) from where traffic arrived.")]
	public class Metro: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metro" />.
		/// </summary>
		public Metro(): base("Metro",true,"ga:metro")
		{
			
		}
	}
}

