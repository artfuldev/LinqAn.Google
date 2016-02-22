using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe.
	/// </summary>
	[Description("The sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe.")]
	public class SubContinent: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SubContinent" />.
		/// </summary>
		public SubContinent(): base("Sub Continent",true,"ga:subContinent")
		{
			
		}
	}
}

