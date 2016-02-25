using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Refers to content group that was visited before another content group.
	/// </summary>
	[Description("Refers to content group that was visited before another content group.")]
	public class PreviousContentGroup3: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PreviousContentGroup3" />.
		/// </summary>
		public PreviousContentGroup3(): base("Previous Page Group 3",true,"ga:previousContentGroup3")
		{
			
		}
	}
}

