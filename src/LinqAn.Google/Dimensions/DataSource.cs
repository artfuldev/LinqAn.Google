using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The data source of a hit. By default, hits sent from ga.js and analytics.js are reported as "web". Hits sent from the mobile SDKs are reported as "app". These values can be overridden in the Measurement Protocol.
	/// </summary>
	[Description("The data source of a hit. By default, hits sent from ga.js and analytics.js are reported as \"web\". Hits sent from the mobile SDKs are reported as \"app\". These values can be overridden in the Measurement Protocol.")]
	public class DataSource: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DataSource" />.
		/// </summary>
		public DataSource(): base("Data Source",true,"ga:dataSource")
		{
			
		}
	}
}

