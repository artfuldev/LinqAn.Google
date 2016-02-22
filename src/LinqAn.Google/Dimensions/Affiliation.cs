using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Typically used to designate a supplying company or brick and mortar location; product affiliation.
	/// </summary>
	[Description("Typically used to designate a supplying company or brick and mortar location; product affiliation.")]
	public class Affiliation: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Affiliation" />.
		/// </summary>
		public Affiliation(): base("Affiliation",true,"ga:affiliation")
		{
			
		}
	}
}

