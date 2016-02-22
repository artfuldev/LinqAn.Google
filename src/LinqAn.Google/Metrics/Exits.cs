using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exits from your property.
	/// </summary>
	[Description("The number of exits from your property.")]
	public class Exits: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Exits" />.
		/// </summary>
		public Exits(): base("Exits",true,"ga:exits")
		{
			
		}
	}
}

