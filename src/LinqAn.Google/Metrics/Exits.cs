namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exits from your property.
	/// </summary>
	public class Exits: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Exits" />.
		/// </summary>
		public Exits(): base("Exits","The number of exits from your property.",true,"ga:exits")
		{
			
		}
	}
}

