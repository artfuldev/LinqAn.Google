using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Refers to content group that was visited before another content group.
	/// </summary>
	[Description("Refers to content group that was visited before another content group.")]
	public class PreviousContentGroup1: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PreviousContentGroup1" />.
		/// </summary>
		public PreviousContentGroup1(): base("Previous Page Group 1",true,"ga:previousContentGroup1")
		{
			
		}
	}
}

