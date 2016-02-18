namespace DotNetAnalytics.Google.Dimensions
{
	public class OriginatingSocialActionDimension: Dimension<string>
	{
		/// <summary>
		/// 	For a social data hub activity, this value represents the type of social action associated with the activity (e.g. vote, comment, +1, etc.).
		/// </summary>
		public OriginatingSocialActionDimension(): base("Originating Social Action","For a social data hub activity, this value represents the type of social action associated with the activity (e.g. vote, comment, +1, etc.).",false,"ga:socialActivityAction")
		{
			
		}
	}
}

