using LinqAn.Google.Metrics;
using LinqAn.Google.Dimensions;

namespace LinqAn.Google.Records
{
	public class Record : IRecord
	{
		/// <summary>
		 /// 	The id of the view to query.
		/// </summary>
		public uint ViewId { get; set; }
		/// <summary>
		 /// 	The date of the record to query.
		/// </summary>
		public System.DateTime RecordDate { get; set; }
		/// <summary>
		/// 	The total number of users for the requested time period.
		/// </summary>
		public Users Users { get; set; }
		/// <summary>
		/// 	The number of users whose session was marked as a first-time session.
		/// </summary>
		public NewUsers NewUsers { get; set; }
		/// <summary>
		/// 	The percentage of sessions by people who had never visited your property before.
		/// </summary>
		public PercentNewSessions PercentNewSessions { get; set; }
		/// <summary>
		/// 	Total number of 1-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 1 day period ending on the given date.
		/// </summary>
		public OneDayUsers OneDayUsers { get; set; }
		/// <summary>
		/// 	Total number of 7-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 7 day period ending on the given date.
		/// </summary>
		public SevenDayUsers SevenDayUsers { get; set; }
		/// <summary>
		/// 	Total number of 14-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date.
		/// </summary>
		public FourteenDayUsers FourteenDayUsers { get; set; }
		/// <summary>
		/// 	Total number of 30-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 30 day period ending on the given date.
		/// </summary>
		public ThirtyDayUsers ThirtyDayUsers { get; set; }
		/// <summary>
		/// 	The total number of sessions.
		/// </summary>
		public Sessions Sessions { get; set; }
		/// <summary>
		/// 	The total number of single page (or single engagement hit) sessions for your property.
		/// </summary>
		public Bounces Bounces { get; set; }
		/// <summary>
		/// 	The percentage of single-page session (i.e., session in which the person left your property from the first page).
		/// </summary>
		public BounceRate BounceRate { get; set; }
		/// <summary>
		/// 	The total duration of user sessions represented in total seconds.
		/// </summary>
		public SessionDuration SessionDuration { get; set; }
		/// <summary>
		/// 	The average duration of user sessions represented in total seconds.
		/// </summary>
		public AvgSessionDuration AvgSessionDuration { get; set; }
		/// <summary>
		/// 	The number of organic searches that happened within a session. This metric is search engine agnostic.
		/// </summary>
		public OrganicSearches OrganicSearches { get; set; }
		/// <summary>
		/// 	Total number of campaign impressions.
		/// </summary>
		public Impressions Impressions { get; set; }
		/// <summary>
		/// 	The total number of times users have clicked on an ad to reach your property.
		/// </summary>
		public AdClicks AdClicks { get; set; }
		/// <summary>
		/// 	Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account.
		/// </summary>
		public AdCost AdCost { get; set; }
		/// <summary>
		/// 	Cost per thousand impressions.
		/// </summary>
		public CPM CPM { get; set; }
		/// <summary>
		/// 	Cost to advertiser per click.
		/// </summary>
		public CPC CPC { get; set; }
		/// <summary>
		/// 	Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared).
		/// </summary>
		public CTR CTR { get; set; }
		/// <summary>
		/// 	The cost per transaction for your property.
		/// </summary>
		public CostPerTransaction CostPerTransaction { get; set; }
		/// <summary>
		/// 	The cost per goal conversion for your property.
		/// </summary>
		public CostPerGoalConversion CostPerGoalConversion { get; set; }
		/// <summary>
		/// 	The cost per conversion (including ecommerce and goal conversions) for your property.
		/// </summary>
		public CostPerConversion CostPerConversion { get; set; }
		/// <summary>
		/// 	RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads.
		/// </summary>
		public RPC RPC { get; set; }
		/// <summary>
		/// 	Return On Ad Spend (ROAS) is the total transaction revenue and goal value divided by derived advertising cost.
		/// </summary>
		public ROAS ROAS { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal1Starts Goal1Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal2Starts Goal2Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal3Starts Goal3Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal4Starts Goal4Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal5Starts Goal5Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal6Starts Goal6Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal7Starts Goal7Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal8Starts Goal8Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal9Starts Goal9Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal10Starts Goal10Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal11Starts Goal11Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal12Starts Goal12Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal13Starts Goal13Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal14Starts Goal14Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal15Starts Goal15Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal16Starts Goal16Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal17Starts Goal17Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal18Starts Goal18Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal19Starts Goal19Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		public Goal20Starts Goal20Starts { get; set; }
		/// <summary>
		/// 	The total number of starts for all goals defined for your profile.
		/// </summary>
		public GoalStartsAll GoalStartsAll { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal1Completions Goal1Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal2Completions Goal2Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal3Completions Goal3Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal4Completions Goal4Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal5Completions Goal5Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal6Completions Goal6Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal7Completions Goal7Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal8Completions Goal8Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal9Completions Goal9Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal10Completions Goal10Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal11Completions Goal11Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal12Completions Goal12Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal13Completions Goal13Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal14Completions Goal14Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal15Completions Goal15Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal16Completions Goal16Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal17Completions Goal17Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal18Completions Goal18Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal19Completions Goal19Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		public Goal20Completions Goal20Completions { get; set; }
		/// <summary>
		/// 	The total number of completions for all goals defined for your profile.
		/// </summary>
		public GoalCompletionsAll GoalCompletionsAll { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal1Value Goal1Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal2Value Goal2Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal3Value Goal3Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal4Value Goal4Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal5Value Goal5Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal6Value Goal6Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal7Value Goal7Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal8Value Goal8Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal9Value Goal9Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal10Value Goal10Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal11Value Goal11Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal12Value Goal12Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal13Value Goal13Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal14Value Goal14Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal15Value Goal15Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal16Value Goal16Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal17Value Goal17Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal18Value Goal18Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal19Value Goal19Value { get; set; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		public Goal20Value Goal20Value { get; set; }
		/// <summary>
		/// 	The total numeric value for all goals defined for your profile.
		/// </summary>
		public GoalValueAll GoalValueAll { get; set; }
		/// <summary>
		/// 	The average goal value of a session.
		/// </summary>
		public GoalValuePerSession GoalValuePerSession { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal1ConversionRate Goal1ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal2ConversionRate Goal2ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal3ConversionRate Goal3ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal4ConversionRate Goal4ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal5ConversionRate Goal5ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal6ConversionRate Goal6ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal7ConversionRate Goal7ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal8ConversionRate Goal8ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal9ConversionRate Goal9ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal10ConversionRate Goal10ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal11ConversionRate Goal11ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal12ConversionRate Goal12ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal13ConversionRate Goal13ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal14ConversionRate Goal14ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal15ConversionRate Goal15ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal16ConversionRate Goal16ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal17ConversionRate Goal17ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal18ConversionRate Goal18ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal19ConversionRate Goal19ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		public Goal20ConversionRate Goal20ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to at least one of your goals.
		/// </summary>
		public GoalConversionRateAll GoalConversionRateAll { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal1Abandons Goal1Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal2Abandons Goal2Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal3Abandons Goal3Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal4Abandons Goal4Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal5Abandons Goal5Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal6Abandons Goal6Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal7Abandons Goal7Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal8Abandons Goal8Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal9Abandons Goal9Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal10Abandons Goal10Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal11Abandons Goal11Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal12Abandons Goal12Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal13Abandons Goal13Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal14Abandons Goal14Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal15Abandons Goal15Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal16Abandons Goal16Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal17Abandons Goal17Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal18Abandons Goal18Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal19Abandons Goal19Abandons { get; set; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		public Goal20Abandons Goal20Abandons { get; set; }
		/// <summary>
		/// 	The overall number of times users started goals without actually completing them.
		/// </summary>
		public GoalAbandonsAll GoalAbandonsAll { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal1AbandonRate Goal1AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal2AbandonRate Goal2AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal3AbandonRate Goal3AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal4AbandonRate Goal4AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal5AbandonRate Goal5AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal6AbandonRate Goal6AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal7AbandonRate Goal7AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal8AbandonRate Goal8AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal9AbandonRate Goal9AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal10AbandonRate Goal10AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal11AbandonRate Goal11AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal12AbandonRate Goal12AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal13AbandonRate Goal13AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal14AbandonRate Goal14AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal15AbandonRate Goal15AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal16AbandonRate Goal16AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal17AbandonRate Goal17AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal18AbandonRate Goal18AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal19AbandonRate Goal19AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		public Goal20AbandonRate Goal20AbandonRate { get; set; }
		/// <summary>
		/// 	The rate at which goals were abandoned.
		/// </summary>
		public GoalAbandonRateAll GoalAbandonRateAll { get; set; }
		/// <summary>
		/// 	The total number of activities where a content URL was shared / mentioned on a social data hub partner network.
		/// </summary>
		public SocialActivities SocialActivities { get; set; }
		/// <summary>
		/// 	The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).
		/// </summary>
		public PageValue PageValue { get; set; }
		/// <summary>
		/// 	The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath
		/// </summary>
		public Entrances Entrances { get; set; }
		/// <summary>
		/// 	The percentage of pageviews in which this page was the entrance.
		/// </summary>
		public EntranceRate EntranceRate { get; set; }
		/// <summary>
		/// 	The total number of pageviews for your property.
		/// </summary>
		public Pageviews Pageviews { get; set; }
		/// <summary>
		/// 	The average number of pages viewed during a session, including repeated views of a single page.
		/// </summary>
		public PageviewsPerSession PageviewsPerSession { get; set; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		public ContentGroupUniqueViews1 ContentGroupUniqueViews1 { get; set; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		public ContentGroupUniqueViews2 ContentGroupUniqueViews2 { get; set; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		public ContentGroupUniqueViews3 ContentGroupUniqueViews3 { get; set; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		public ContentGroupUniqueViews4 ContentGroupUniqueViews4 { get; set; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		public ContentGroupUniqueViews5 ContentGroupUniqueViews5 { get; set; }
		/// <summary>
		/// 	The number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		public UniquePageviews UniquePageviews { get; set; }
		/// <summary>
		/// 	How long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.
		/// </summary>
		public TimeOnPage TimeOnPage { get; set; }
		/// <summary>
		/// 	The average amount of time users spent viewing this page or a set of pages.
		/// </summary>
		public AvgTimeOnPage AvgTimeOnPage { get; set; }
		/// <summary>
		/// 	The number of exits from your property.
		/// </summary>
		public Exits Exits { get; set; }
		/// <summary>
		/// 	The percentage of exits from your property that occurred out of the total page views.
		/// </summary>
		public ExitRate ExitRate { get; set; }
		/// <summary>
		/// 	The number of times a search result page was viewed after performing a search.
		/// </summary>
		public SearchResultViews SearchResultViews { get; set; }
		/// <summary>
		/// 	The total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once.
		/// </summary>
		public SearchUniques SearchUniques { get; set; }
		/// <summary>
		/// 	The average number of times people viewed a search results page after performing a search.
		/// </summary>
		public AvgSearchResultViews AvgSearchResultViews { get; set; }
		/// <summary>
		/// 	The total number of sessions that included an internal search
		/// </summary>
		public SearchSessions SearchSessions { get; set; }
		/// <summary>
		/// 	The percentage of sessions with search.
		/// </summary>
		public PercentSessionsWithSearch PercentSessionsWithSearch { get; set; }
		/// <summary>
		/// 	The total number of subsequent page views made after a use of your internal search feature.
		/// </summary>
		public SearchDepth SearchDepth { get; set; }
		/// <summary>
		/// 	The average number of pages people viewed after performing a search.
		/// </summary>
		public AvgSearchDepth AvgSearchDepth { get; set; }
		/// <summary>
		/// 	The total number of times a refinement (transition) occurs between internal search keywords within a session. For example if the sequence of keywords is: "shoes", "shoes", "pants", "pants", this metric will be one because the transition between "shoes" and "pants" is different.
		/// </summary>
		public SearchRefinements SearchRefinements { get; set; }
		/// <summary>
		/// 	The percentage of number of times a refinement (i.e., transition) occurs between internal search keywords within a session.
		/// </summary>
		public PercentSearchRefinements PercentSearchRefinements { get; set; }
		/// <summary>
		/// 	The session duration where a use of your internal search feature occurred.
		/// </summary>
		public SearchDuration SearchDuration { get; set; }
		/// <summary>
		/// 	The average time (in seconds) users spent on your property after searching.
		/// </summary>
		public AvgSearchDuration AvgSearchDuration { get; set; }
		/// <summary>
		/// 	The number of exits on your site that occurred following a search result from your internal search feature.
		/// </summary>
		public SearchExits SearchExits { get; set; }
		/// <summary>
		/// 	The percentage of searches that resulted in an immediate exit from your property.
		/// </summary>
		public SearchExitRate SearchExitRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal1ConversionRate SearchGoal1ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal2ConversionRate SearchGoal2ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal3ConversionRate SearchGoal3ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal4ConversionRate SearchGoal4ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal5ConversionRate SearchGoal5ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal6ConversionRate SearchGoal6ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal7ConversionRate SearchGoal7ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal8ConversionRate SearchGoal8ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal9ConversionRate SearchGoal9ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal10ConversionRate SearchGoal10ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal11ConversionRate SearchGoal11ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal12ConversionRate SearchGoal12ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal13ConversionRate SearchGoal13ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal14ConversionRate SearchGoal14ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal15ConversionRate SearchGoal15ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal16ConversionRate SearchGoal16ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal17ConversionRate SearchGoal17ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal18ConversionRate SearchGoal18ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal19ConversionRate SearchGoal19ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		public SearchGoal20ConversionRate SearchGoal20ConversionRate { get; set; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to at least one of your goals.
		/// </summary>
		public SearchGoalConversionRateAll SearchGoalConversionRateAll { get; set; }
		/// <summary>
		/// 	The average goal value of a search.
		/// </summary>
		public GoalValueAllPerSearch GoalValueAllPerSearch { get; set; }
		/// <summary>
		/// 	Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
		/// </summary>
		public PageLoadTime PageLoadTime { get; set; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the average page load time.
		/// </summary>
		public PageLoadSample PageLoadSample { get; set; }
		/// <summary>
		/// 	The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
		/// </summary>
		public AvgPageLoadTime AvgPageLoadTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.
		/// </summary>
		public DomainLookupTime DomainLookupTime { get; set; }
		/// <summary>
		/// 	The average amount of time (in seconds) spent in DNS lookup for this page.
		/// </summary>
		public AvgDomainLookupTime AvgDomainLookupTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) to download this page among all samples.
		/// </summary>
		public PageDownloadTime PageDownloadTime { get; set; }
		/// <summary>
		/// 	The average amount of time (in seconds) to download this page.
		/// </summary>
		public AvgPageDownloadTime AvgPageDownloadTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.
		/// </summary>
		public RedirectionTime RedirectionTime { get; set; }
		/// <summary>
		/// 	The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0.
		/// </summary>
		public AvgRedirectionTime AvgRedirectionTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.
		/// </summary>
		public ServerConnectionTime ServerConnectionTime { get; set; }
		/// <summary>
		/// 	The average amount of time (in seconds) spent in establishing TCP connection for this page.
		/// </summary>
		public AvgServerConnectionTime AvgServerConnectionTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.
		/// </summary>
		public ServerResponseTime ServerResponseTime { get; set; }
		/// <summary>
		/// 	The average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server.
		/// </summary>
		public AvgServerResponseTime AvgServerResponseTime { get; set; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
		/// </summary>
		public SpeedMetricsSample SpeedMetricsSample { get; set; }
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.
		/// </summary>
		public DomInteractiveTime DomInteractiveTime { get; set; }
		/// <summary>
		/// 	The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server.
		/// </summary>
		public AvgDomInteractiveTime AvgDomInteractiveTime { get; set; }
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.
		/// </summary>
		public DomContentLoadedTime DomContentLoadedTime { get; set; }
		/// <summary>
		/// 	The average time (in seconds) it takes the browser to parse the document.
		/// </summary>
		public AvgDomContentLoadedTime AvgDomContentLoadedTime { get; set; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.
		/// </summary>
		public DomLatencyMetricsSample DomLatencyMetricsSample { get; set; }
		/// <summary>
		/// 	The total number of screenviews.
		/// </summary>
		public Screenviews Screenviews { get; set; }
		/// <summary>
		/// 	The number of unique screen views. Screen views in different sessions count a separate screen views.
		/// </summary>
		public UniqueScreenviews UniqueScreenviews { get; set; }
		/// <summary>
		/// 	The average number of screenviews per session.
		/// </summary>
		public ScreenviewsPerSession ScreenviewsPerSession { get; set; }
		/// <summary>
		/// 	The time spent viewing the current screen.
		/// </summary>
		public TimeOnScreen TimeOnScreen { get; set; }
		/// <summary>
		/// 	The average amount of time users spent on a screen in seconds.
		/// </summary>
		public AvgScreenviewDuration AvgScreenviewDuration { get; set; }
		/// <summary>
		/// 	The total number of events for the profile, across all categories.
		/// </summary>
		public TotalEvents TotalEvents { get; set; }
		/// <summary>
		/// 	The number of unique events. Events in different sessions count as separate events.
		/// </summary>
		public UniqueEvents UniqueEvents { get; set; }
		/// <summary>
		/// 	The total value of events for the profile.
		/// </summary>
		public EventValue EventValue { get; set; }
		/// <summary>
		/// 	The average value of an event.
		/// </summary>
		public AvgEventValue AvgEventValue { get; set; }
		/// <summary>
		/// 	The total number of sessions with events.
		/// </summary>
		public SessionsWithEvent SessionsWithEvent { get; set; }
		/// <summary>
		/// 	The average number of events per session with event.
		/// </summary>
		public EventsPerSessionWithEvent EventsPerSessionWithEvent { get; set; }
		/// <summary>
		/// 	The total number of transactions.
		/// </summary>
		public Transactions Transactions { get; set; }
		/// <summary>
		/// 	The average number of transactions for a session.
		/// </summary>
		public TransactionsPerSession TransactionsPerSession { get; set; }
		/// <summary>
		/// 	The total sale revenue provided in the transaction excluding shipping and tax.
		/// </summary>
		public TransactionRevenue TransactionRevenue { get; set; }
		/// <summary>
		/// 	The average revenue for an e-commerce transaction.
		/// </summary>
		public RevenuePerTransaction RevenuePerTransaction { get; set; }
		/// <summary>
		/// 	Average transaction revenue for a session.
		/// </summary>
		public TransactionRevenuePerSession TransactionRevenuePerSession { get; set; }
		/// <summary>
		/// 	The total cost of shipping.
		/// </summary>
		public TransactionShipping TransactionShipping { get; set; }
		/// <summary>
		/// 	The total amount of tax.
		/// </summary>
		public TransactionTax TransactionTax { get; set; }
		/// <summary>
		/// 	Total value for your property (including total revenue and total goal value).
		/// </summary>
		public TotalValue TotalValue { get; set; }
		/// <summary>
		/// 	The total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased.
		/// </summary>
		public ItemQuantity ItemQuantity { get; set; }
		/// <summary>
		/// 	The number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased.
		/// </summary>
		public UniquePurchases UniquePurchases { get; set; }
		/// <summary>
		/// 	The average revenue per item.
		/// </summary>
		public RevenuePerItem RevenuePerItem { get; set; }
		/// <summary>
		/// 	The total revenue from purchased product items.
		/// </summary>
		public ItemRevenue ItemRevenue { get; set; }
		/// <summary>
		/// 	The average quantity of this item (or group of items) sold per purchase.
		/// </summary>
		public ItemsPerPurchase ItemsPerPurchase { get; set; }
		/// <summary>
		/// 	Transaction revenue in local currency.
		/// </summary>
		public LocalTransactionRevenue LocalTransactionRevenue { get; set; }
		/// <summary>
		/// 	Transaction shipping cost in local currency.
		/// </summary>
		public LocalTransactionShipping LocalTransactionShipping { get; set; }
		/// <summary>
		/// 	Transaction tax in local currency.
		/// </summary>
		public LocalTransactionTax LocalTransactionTax { get; set; }
		/// <summary>
		/// 	Product revenue in local currency.
		/// </summary>
		public LocalItemRevenue LocalItemRevenue { get; set; }
		/// <summary>
		/// 	The total number of social interactions.
		/// </summary>
		public SocialInteractions SocialInteractions { get; set; }
		/// <summary>
		/// 	The number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget.
		/// </summary>
		public UniqueSocialInteractions UniqueSocialInteractions { get; set; }
		/// <summary>
		/// 	The number of social interactions per session.
		/// </summary>
		public SocialInteractionsPerSession SocialInteractionsPerSession { get; set; }
		/// <summary>
		/// 	The total number of milliseconds for a user timing.
		/// </summary>
		public UserTimingValue UserTimingValue { get; set; }
		/// <summary>
		/// 	The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.
		/// </summary>
		public UserTimingSample UserTimingSample { get; set; }
		/// <summary>
		/// 	The average amount of elapsed time.
		/// </summary>
		public AvgUserTimingValue AvgUserTimingValue { get; set; }
		/// <summary>
		/// 	The number of exceptions that were sent to Google Analytics.
		/// </summary>
		public Exceptions Exceptions { get; set; }
		/// <summary>
		/// 	The number of exceptions thrown divided by the number of screenviews.
		/// </summary>
		public ExceptionsPerScreenview ExceptionsPerScreenview { get; set; }
		/// <summary>
		/// 	The number of exceptions where isFatal is set to true.
		/// </summary>
		public FatalExceptions FatalExceptions { get; set; }
		/// <summary>
		/// 	The number of fatal exceptions thrown divided by the number of screenviews.
		/// </summary>
		public FatalExceptionsPerScreenview FatalExceptionsPerScreenview { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 1 refers the number/index of the custom metric. Note that the data type of ga:metric1 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric1 Metric1 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 2 refers the number/index of the custom metric. Note that the data type of ga:metric2 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric2 Metric2 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 3 refers the number/index of the custom metric. Note that the data type of ga:metric3 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric3 Metric3 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 4 refers the number/index of the custom metric. Note that the data type of ga:metric4 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric4 Metric4 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 5 refers the number/index of the custom metric. Note that the data type of ga:metric5 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric5 Metric5 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 6 refers the number/index of the custom metric. Note that the data type of ga:metric6 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric6 Metric6 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 7 refers the number/index of the custom metric. Note that the data type of ga:metric7 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric7 Metric7 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 8 refers the number/index of the custom metric. Note that the data type of ga:metric8 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric8 Metric8 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 9 refers the number/index of the custom metric. Note that the data type of ga:metric9 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric9 Metric9 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 10 refers the number/index of the custom metric. Note that the data type of ga:metric10 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric10 Metric10 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 11 refers the number/index of the custom metric. Note that the data type of ga:metric11 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric11 Metric11 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 12 refers the number/index of the custom metric. Note that the data type of ga:metric12 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric12 Metric12 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 13 refers the number/index of the custom metric. Note that the data type of ga:metric13 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric13 Metric13 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 14 refers the number/index of the custom metric. Note that the data type of ga:metric14 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric14 Metric14 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 15 refers the number/index of the custom metric. Note that the data type of ga:metric15 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric15 Metric15 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 16 refers the number/index of the custom metric. Note that the data type of ga:metric16 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric16 Metric16 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 17 refers the number/index of the custom metric. Note that the data type of ga:metric17 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric17 Metric17 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 18 refers the number/index of the custom metric. Note that the data type of ga:metric18 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric18 Metric18 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 19 refers the number/index of the custom metric. Note that the data type of ga:metric19 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric19 Metric19 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 20 refers the number/index of the custom metric. Note that the data type of ga:metric20 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric20 Metric20 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 21 refers the number/index of the custom metric. Note that the data type of ga:metric21 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric21 Metric21 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 22 refers the number/index of the custom metric. Note that the data type of ga:metric22 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric22 Metric22 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 23 refers the number/index of the custom metric. Note that the data type of ga:metric23 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric23 Metric23 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 24 refers the number/index of the custom metric. Note that the data type of ga:metric24 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric24 Metric24 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 25 refers the number/index of the custom metric. Note that the data type of ga:metric25 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric25 Metric25 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 26 refers the number/index of the custom metric. Note that the data type of ga:metric26 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric26 Metric26 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 27 refers the number/index of the custom metric. Note that the data type of ga:metric27 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric27 Metric27 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 28 refers the number/index of the custom metric. Note that the data type of ga:metric28 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric28 Metric28 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 29 refers the number/index of the custom metric. Note that the data type of ga:metric29 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric29 Metric29 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 30 refers the number/index of the custom metric. Note that the data type of ga:metric30 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric30 Metric30 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 31 refers the number/index of the custom metric. Note that the data type of ga:metric31 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric31 Metric31 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 32 refers the number/index of the custom metric. Note that the data type of ga:metric32 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric32 Metric32 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 33 refers the number/index of the custom metric. Note that the data type of ga:metric33 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric33 Metric33 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 34 refers the number/index of the custom metric. Note that the data type of ga:metric34 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric34 Metric34 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 35 refers the number/index of the custom metric. Note that the data type of ga:metric35 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric35 Metric35 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 36 refers the number/index of the custom metric. Note that the data type of ga:metric36 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric36 Metric36 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 37 refers the number/index of the custom metric. Note that the data type of ga:metric37 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric37 Metric37 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 38 refers the number/index of the custom metric. Note that the data type of ga:metric38 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric38 Metric38 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 39 refers the number/index of the custom metric. Note that the data type of ga:metric39 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric39 Metric39 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 40 refers the number/index of the custom metric. Note that the data type of ga:metric40 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric40 Metric40 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 41 refers the number/index of the custom metric. Note that the data type of ga:metric41 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric41 Metric41 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 42 refers the number/index of the custom metric. Note that the data type of ga:metric42 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric42 Metric42 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 43 refers the number/index of the custom metric. Note that the data type of ga:metric43 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric43 Metric43 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 44 refers the number/index of the custom metric. Note that the data type of ga:metric44 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric44 Metric44 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 45 refers the number/index of the custom metric. Note that the data type of ga:metric45 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric45 Metric45 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 46 refers the number/index of the custom metric. Note that the data type of ga:metric46 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric46 Metric46 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 47 refers the number/index of the custom metric. Note that the data type of ga:metric47 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric47 Metric47 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 48 refers the number/index of the custom metric. Note that the data type of ga:metric48 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric48 Metric48 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 49 refers the number/index of the custom metric. Note that the data type of ga:metric49 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric49 Metric49 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 50 refers the number/index of the custom metric. Note that the data type of ga:metric50 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric50 Metric50 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 51 refers the number/index of the custom metric. Note that the data type of ga:metric51 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric51 Metric51 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 52 refers the number/index of the custom metric. Note that the data type of ga:metric52 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric52 Metric52 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 53 refers the number/index of the custom metric. Note that the data type of ga:metric53 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric53 Metric53 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 54 refers the number/index of the custom metric. Note that the data type of ga:metric54 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric54 Metric54 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 55 refers the number/index of the custom metric. Note that the data type of ga:metric55 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric55 Metric55 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 56 refers the number/index of the custom metric. Note that the data type of ga:metric56 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric56 Metric56 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 57 refers the number/index of the custom metric. Note that the data type of ga:metric57 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric57 Metric57 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 58 refers the number/index of the custom metric. Note that the data type of ga:metric58 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric58 Metric58 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 59 refers the number/index of the custom metric. Note that the data type of ga:metric59 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric59 Metric59 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 60 refers the number/index of the custom metric. Note that the data type of ga:metric60 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric60 Metric60 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 61 refers the number/index of the custom metric. Note that the data type of ga:metric61 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric61 Metric61 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 62 refers the number/index of the custom metric. Note that the data type of ga:metric62 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric62 Metric62 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 63 refers the number/index of the custom metric. Note that the data type of ga:metric63 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric63 Metric63 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 64 refers the number/index of the custom metric. Note that the data type of ga:metric64 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric64 Metric64 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 65 refers the number/index of the custom metric. Note that the data type of ga:metric65 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric65 Metric65 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 66 refers the number/index of the custom metric. Note that the data type of ga:metric66 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric66 Metric66 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 67 refers the number/index of the custom metric. Note that the data type of ga:metric67 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric67 Metric67 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 68 refers the number/index of the custom metric. Note that the data type of ga:metric68 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric68 Metric68 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 69 refers the number/index of the custom metric. Note that the data type of ga:metric69 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric69 Metric69 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 70 refers the number/index of the custom metric. Note that the data type of ga:metric70 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric70 Metric70 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 71 refers the number/index of the custom metric. Note that the data type of ga:metric71 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric71 Metric71 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 72 refers the number/index of the custom metric. Note that the data type of ga:metric72 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric72 Metric72 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 73 refers the number/index of the custom metric. Note that the data type of ga:metric73 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric73 Metric73 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 74 refers the number/index of the custom metric. Note that the data type of ga:metric74 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric74 Metric74 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 75 refers the number/index of the custom metric. Note that the data type of ga:metric75 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric75 Metric75 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 76 refers the number/index of the custom metric. Note that the data type of ga:metric76 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric76 Metric76 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 77 refers the number/index of the custom metric. Note that the data type of ga:metric77 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric77 Metric77 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 78 refers the number/index of the custom metric. Note that the data type of ga:metric78 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric78 Metric78 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 79 refers the number/index of the custom metric. Note that the data type of ga:metric79 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric79 Metric79 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 80 refers the number/index of the custom metric. Note that the data type of ga:metric80 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric80 Metric80 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 81 refers the number/index of the custom metric. Note that the data type of ga:metric81 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric81 Metric81 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 82 refers the number/index of the custom metric. Note that the data type of ga:metric82 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric82 Metric82 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 83 refers the number/index of the custom metric. Note that the data type of ga:metric83 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric83 Metric83 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 84 refers the number/index of the custom metric. Note that the data type of ga:metric84 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric84 Metric84 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 85 refers the number/index of the custom metric. Note that the data type of ga:metric85 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric85 Metric85 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 86 refers the number/index of the custom metric. Note that the data type of ga:metric86 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric86 Metric86 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 87 refers the number/index of the custom metric. Note that the data type of ga:metric87 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric87 Metric87 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 88 refers the number/index of the custom metric. Note that the data type of ga:metric88 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric88 Metric88 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 89 refers the number/index of the custom metric. Note that the data type of ga:metric89 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric89 Metric89 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 90 refers the number/index of the custom metric. Note that the data type of ga:metric90 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric90 Metric90 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 91 refers the number/index of the custom metric. Note that the data type of ga:metric91 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric91 Metric91 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 92 refers the number/index of the custom metric. Note that the data type of ga:metric92 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric92 Metric92 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 93 refers the number/index of the custom metric. Note that the data type of ga:metric93 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric93 Metric93 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 94 refers the number/index of the custom metric. Note that the data type of ga:metric94 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric94 Metric94 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 95 refers the number/index of the custom metric. Note that the data type of ga:metric95 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric95 Metric95 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 96 refers the number/index of the custom metric. Note that the data type of ga:metric96 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric96 Metric96 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 97 refers the number/index of the custom metric. Note that the data type of ga:metric97 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric97 Metric97 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 98 refers the number/index of the custom metric. Note that the data type of ga:metric98 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric98 Metric98 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 99 refers the number/index of the custom metric. Note that the data type of ga:metric99 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric99 Metric99 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 100 refers the number/index of the custom metric. Note that the data type of ga:metric100 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric100 Metric100 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 101 refers the number/index of the custom metric. Note that the data type of ga:metric101 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric101 Metric101 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 102 refers the number/index of the custom metric. Note that the data type of ga:metric102 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric102 Metric102 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 103 refers the number/index of the custom metric. Note that the data type of ga:metric103 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric103 Metric103 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 104 refers the number/index of the custom metric. Note that the data type of ga:metric104 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric104 Metric104 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 105 refers the number/index of the custom metric. Note that the data type of ga:metric105 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric105 Metric105 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 106 refers the number/index of the custom metric. Note that the data type of ga:metric106 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric106 Metric106 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 107 refers the number/index of the custom metric. Note that the data type of ga:metric107 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric107 Metric107 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 108 refers the number/index of the custom metric. Note that the data type of ga:metric108 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric108 Metric108 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 109 refers the number/index of the custom metric. Note that the data type of ga:metric109 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric109 Metric109 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 110 refers the number/index of the custom metric. Note that the data type of ga:metric110 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric110 Metric110 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 111 refers the number/index of the custom metric. Note that the data type of ga:metric111 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric111 Metric111 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 112 refers the number/index of the custom metric. Note that the data type of ga:metric112 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric112 Metric112 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 113 refers the number/index of the custom metric. Note that the data type of ga:metric113 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric113 Metric113 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 114 refers the number/index of the custom metric. Note that the data type of ga:metric114 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric114 Metric114 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 115 refers the number/index of the custom metric. Note that the data type of ga:metric115 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric115 Metric115 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 116 refers the number/index of the custom metric. Note that the data type of ga:metric116 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric116 Metric116 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 117 refers the number/index of the custom metric. Note that the data type of ga:metric117 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric117 Metric117 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 118 refers the number/index of the custom metric. Note that the data type of ga:metric118 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric118 Metric118 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 119 refers the number/index of the custom metric. Note that the data type of ga:metric119 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric119 Metric119 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 120 refers the number/index of the custom metric. Note that the data type of ga:metric120 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric120 Metric120 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 121 refers the number/index of the custom metric. Note that the data type of ga:metric121 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric121 Metric121 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 122 refers the number/index of the custom metric. Note that the data type of ga:metric122 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric122 Metric122 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 123 refers the number/index of the custom metric. Note that the data type of ga:metric123 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric123 Metric123 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 124 refers the number/index of the custom metric. Note that the data type of ga:metric124 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric124 Metric124 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 125 refers the number/index of the custom metric. Note that the data type of ga:metric125 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric125 Metric125 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 126 refers the number/index of the custom metric. Note that the data type of ga:metric126 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric126 Metric126 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 127 refers the number/index of the custom metric. Note that the data type of ga:metric127 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric127 Metric127 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 128 refers the number/index of the custom metric. Note that the data type of ga:metric128 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric128 Metric128 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 129 refers the number/index of the custom metric. Note that the data type of ga:metric129 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric129 Metric129 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 130 refers the number/index of the custom metric. Note that the data type of ga:metric130 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric130 Metric130 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 131 refers the number/index of the custom metric. Note that the data type of ga:metric131 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric131 Metric131 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 132 refers the number/index of the custom metric. Note that the data type of ga:metric132 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric132 Metric132 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 133 refers the number/index of the custom metric. Note that the data type of ga:metric133 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric133 Metric133 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 134 refers the number/index of the custom metric. Note that the data type of ga:metric134 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric134 Metric134 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 135 refers the number/index of the custom metric. Note that the data type of ga:metric135 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric135 Metric135 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 136 refers the number/index of the custom metric. Note that the data type of ga:metric136 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric136 Metric136 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 137 refers the number/index of the custom metric. Note that the data type of ga:metric137 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric137 Metric137 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 138 refers the number/index of the custom metric. Note that the data type of ga:metric138 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric138 Metric138 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 139 refers the number/index of the custom metric. Note that the data type of ga:metric139 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric139 Metric139 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 140 refers the number/index of the custom metric. Note that the data type of ga:metric140 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric140 Metric140 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 141 refers the number/index of the custom metric. Note that the data type of ga:metric141 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric141 Metric141 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 142 refers the number/index of the custom metric. Note that the data type of ga:metric142 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric142 Metric142 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 143 refers the number/index of the custom metric. Note that the data type of ga:metric143 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric143 Metric143 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 144 refers the number/index of the custom metric. Note that the data type of ga:metric144 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric144 Metric144 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 145 refers the number/index of the custom metric. Note that the data type of ga:metric145 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric145 Metric145 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 146 refers the number/index of the custom metric. Note that the data type of ga:metric146 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric146 Metric146 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 147 refers the number/index of the custom metric. Note that the data type of ga:metric147 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric147 Metric147 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 148 refers the number/index of the custom metric. Note that the data type of ga:metric148 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric148 Metric148 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 149 refers the number/index of the custom metric. Note that the data type of ga:metric149 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric149 Metric149 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 150 refers the number/index of the custom metric. Note that the data type of ga:metric150 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric150 Metric150 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 151 refers the number/index of the custom metric. Note that the data type of ga:metric151 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric151 Metric151 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 152 refers the number/index of the custom metric. Note that the data type of ga:metric152 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric152 Metric152 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 153 refers the number/index of the custom metric. Note that the data type of ga:metric153 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric153 Metric153 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 154 refers the number/index of the custom metric. Note that the data type of ga:metric154 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric154 Metric154 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 155 refers the number/index of the custom metric. Note that the data type of ga:metric155 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric155 Metric155 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 156 refers the number/index of the custom metric. Note that the data type of ga:metric156 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric156 Metric156 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 157 refers the number/index of the custom metric. Note that the data type of ga:metric157 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric157 Metric157 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 158 refers the number/index of the custom metric. Note that the data type of ga:metric158 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric158 Metric158 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 159 refers the number/index of the custom metric. Note that the data type of ga:metric159 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric159 Metric159 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 160 refers the number/index of the custom metric. Note that the data type of ga:metric160 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric160 Metric160 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 161 refers the number/index of the custom metric. Note that the data type of ga:metric161 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric161 Metric161 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 162 refers the number/index of the custom metric. Note that the data type of ga:metric162 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric162 Metric162 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 163 refers the number/index of the custom metric. Note that the data type of ga:metric163 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric163 Metric163 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 164 refers the number/index of the custom metric. Note that the data type of ga:metric164 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric164 Metric164 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 165 refers the number/index of the custom metric. Note that the data type of ga:metric165 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric165 Metric165 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 166 refers the number/index of the custom metric. Note that the data type of ga:metric166 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric166 Metric166 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 167 refers the number/index of the custom metric. Note that the data type of ga:metric167 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric167 Metric167 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 168 refers the number/index of the custom metric. Note that the data type of ga:metric168 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric168 Metric168 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 169 refers the number/index of the custom metric. Note that the data type of ga:metric169 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric169 Metric169 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 170 refers the number/index of the custom metric. Note that the data type of ga:metric170 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric170 Metric170 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 171 refers the number/index of the custom metric. Note that the data type of ga:metric171 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric171 Metric171 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 172 refers the number/index of the custom metric. Note that the data type of ga:metric172 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric172 Metric172 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 173 refers the number/index of the custom metric. Note that the data type of ga:metric173 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric173 Metric173 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 174 refers the number/index of the custom metric. Note that the data type of ga:metric174 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric174 Metric174 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 175 refers the number/index of the custom metric. Note that the data type of ga:metric175 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric175 Metric175 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 176 refers the number/index of the custom metric. Note that the data type of ga:metric176 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric176 Metric176 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 177 refers the number/index of the custom metric. Note that the data type of ga:metric177 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric177 Metric177 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 178 refers the number/index of the custom metric. Note that the data type of ga:metric178 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric178 Metric178 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 179 refers the number/index of the custom metric. Note that the data type of ga:metric179 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric179 Metric179 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 180 refers the number/index of the custom metric. Note that the data type of ga:metric180 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric180 Metric180 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 181 refers the number/index of the custom metric. Note that the data type of ga:metric181 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric181 Metric181 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 182 refers the number/index of the custom metric. Note that the data type of ga:metric182 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric182 Metric182 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 183 refers the number/index of the custom metric. Note that the data type of ga:metric183 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric183 Metric183 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 184 refers the number/index of the custom metric. Note that the data type of ga:metric184 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric184 Metric184 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 185 refers the number/index of the custom metric. Note that the data type of ga:metric185 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric185 Metric185 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 186 refers the number/index of the custom metric. Note that the data type of ga:metric186 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric186 Metric186 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 187 refers the number/index of the custom metric. Note that the data type of ga:metric187 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric187 Metric187 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 188 refers the number/index of the custom metric. Note that the data type of ga:metric188 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric188 Metric188 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 189 refers the number/index of the custom metric. Note that the data type of ga:metric189 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric189 Metric189 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 190 refers the number/index of the custom metric. Note that the data type of ga:metric190 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric190 Metric190 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 191 refers the number/index of the custom metric. Note that the data type of ga:metric191 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric191 Metric191 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 192 refers the number/index of the custom metric. Note that the data type of ga:metric192 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric192 Metric192 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 193 refers the number/index of the custom metric. Note that the data type of ga:metric193 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric193 Metric193 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 194 refers the number/index of the custom metric. Note that the data type of ga:metric194 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric194 Metric194 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 195 refers the number/index of the custom metric. Note that the data type of ga:metric195 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric195 Metric195 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 196 refers the number/index of the custom metric. Note that the data type of ga:metric196 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric196 Metric196 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 197 refers the number/index of the custom metric. Note that the data type of ga:metric197 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric197 Metric197 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 198 refers the number/index of the custom metric. Note that the data type of ga:metric198 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric198 Metric198 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 199 refers the number/index of the custom metric. Note that the data type of ga:metric199 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric199 Metric199 { get; set; }
		/// <summary>
		/// 	The name of the requested custom metric, where 200 refers the number/index of the custom metric. Note that the data type of ga:metric200 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		public Metric200 Metric200 { get; set; }
		/// <summary>
		/// 	The number of DCM Floodlight conversions (premium only).
		/// </summary>
		public DcmFloodlightQuantity DcmFloodlightQuantity { get; set; }
		/// <summary>
		/// 	DCM Floodlight revenue (premium only).
		/// </summary>
		public DcmFloodlightRevenue DcmFloodlightRevenue { get; set; }
		/// <summary>
		/// 	The total revenue from AdSense ads.
		/// </summary>
		public AdsenseRevenue AdsenseRevenue { get; set; }
		/// <summary>
		/// 	The number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en
		/// </summary>
		public AdsenseAdUnitsViewed AdsenseAdUnitsViewed { get; set; }
		/// <summary>
		/// 	The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.
		/// </summary>
		public AdsenseAdsViewed AdsenseAdsViewed { get; set; }
		/// <summary>
		/// 	The number of times AdSense ads on your site were clicked.
		/// </summary>
		public AdsenseAdsClicks AdsenseAdsClicks { get; set; }
		/// <summary>
		/// 	The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.
		/// </summary>
		public AdsensePageImpressions AdsensePageImpressions { get; set; }
		/// <summary>
		/// 	The percentage of page impressions that resulted in a click on an AdSense ad.
		/// </summary>
		public AdsenseCTR AdsenseCTR { get; set; }
		/// <summary>
		/// 	The estimated cost per thousand page impressions. It is your AdSense Revenue per 1000 page impressions.
		/// </summary>
		public AdsenseECPM AdsenseECPM { get; set; }
		/// <summary>
		/// 	The number of sessions that ended due to a user clicking on an AdSense ad.
		/// </summary>
		public AdsenseExits AdsenseExits { get; set; }
		/// <summary>
		/// 	The percentage of impressions that were viewable.
		/// </summary>
		public AdsenseViewableImpressionPercent AdsenseViewableImpressionPercent { get; set; }
		/// <summary>
		/// 	The percentage of ad requests that returned at least one ad.
		/// </summary>
		public AdsenseCoverage AdsenseCoverage { get; set; }
		/// <summary>
		/// 	An AdX ad impression is reported whenever an individual ad is displayed on your website. For example, if a page with two ad units is viewed once, we'll display two impressions.
		/// </summary>
		public AdxImpressions AdxImpressions { get; set; }
		/// <summary>
		/// 	Coverage is the percentage of ad requests that returned at least one ad. Generally, coverage can help you identify sites where your AdX account isn't able to provide targeted ads. (Ad Impressions / Total Ad Requests) * 100
		/// </summary>
		public AdxCoverage AdxCoverage { get; set; }
		/// <summary>
		/// 	Monetized Pageviews measures the total number of pageviews on your property that were shown with an ad from your linked AdX account. Note - a single page can have multiple ad units.
		/// </summary>
		public AdxMonetizedPageviews AdxMonetizedPageviews { get; set; }
		/// <summary>
		/// 	The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).
		/// </summary>
		public AdxImpressionsPerSession AdxImpressionsPerSession { get; set; }
		/// <summary>
		/// 	The percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has appeared within a user's browser and had the opportunity to be seen.
		/// </summary>
		public AdxViewableImpressionsPercent AdxViewableImpressionsPercent { get; set; }
		/// <summary>
		/// 	The number of times AdX ads were clicked on your site.
		/// </summary>
		public AdxClicks AdxClicks { get; set; }
		/// <summary>
		/// 	The percentage of pageviews that resulted in a click on an AdX ad.
		/// </summary>
		public AdxCTR AdxCTR { get; set; }
		/// <summary>
		/// 	The total estimated revenue from AdX ads.
		/// </summary>
		public AdxRevenue AdxRevenue { get; set; }
		/// <summary>
		/// 	The total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions.
		/// </summary>
		public AdxRevenuePer1000Sessions AdxRevenuePer1000Sessions { get; set; }
		/// <summary>
		/// 	The effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews.
		/// </summary>
		public AdxECPM AdxECPM { get; set; }
		/// <summary>
		/// 	Unique purchases divided by views of product detail pages (Enhanced Ecommerce).
		/// </summary>
		public BuyToDetailRate BuyToDetailRate { get; set; }
		/// <summary>
		/// 	Product adds divided by views of product details (Enhanced Ecommerce).
		/// </summary>
		public CartToDetailRate CartToDetailRate { get; set; }
		/// <summary>
		/// 	Correlation Score for related products.
		/// </summary>
		public CorrelationScore CorrelationScore { get; set; }
		/// <summary>
		/// 	DCM Cost Per Click (premium only).
		/// </summary>
		public DcmCPC DcmCPC { get; set; }
		/// <summary>
		/// 	DCM Click Through Rate (premium only).
		/// </summary>
		public DcmCTR DcmCTR { get; set; }
		/// <summary>
		/// 	DCM Total Clicks (premium only).
		/// </summary>
		public DcmClicks DcmClicks { get; set; }
		/// <summary>
		/// 	DCM Total Cost (premium only).
		/// </summary>
		public DcmCost DcmCost { get; set; }
		/// <summary>
		/// 	DCM Total Impressions (premium only).
		/// </summary>
		public DcmImpressions DcmImpressions { get; set; }
		/// <summary>
		/// 	DCM Return On Ad Spend (ROAS) (premium only).
		/// </summary>
		public DcmROAS DcmROAS { get; set; }
		/// <summary>
		/// 	DCM Revenue Per Click (premium only).
		/// </summary>
		public DcmRPC DcmRPC { get; set; }
		/// <summary>
		/// 	Total number of hits sent to Google Analytics, for the view (profile). This metric sums all hit types, including pageview, custom event, ecommerce, and other types. Note that this number is based on the view (profile), not the property, and therefore is not the same as the property's hit volume.
		/// </summary>
		public Hits Hits { get; set; }
		/// <summary>
		/// 	The rate at which users clicked through to view the internal promotion (ga:internalPromotionClicks / ga:internalPromotionViews) - (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionCTR InternalPromotionCTR { get; set; }
		/// <summary>
		/// 	The number of clicks on an internal promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionClicks InternalPromotionClicks { get; set; }
		/// <summary>
		/// 	The number of views of an internal promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionViews InternalPromotionViews { get; set; }
		/// <summary>
		/// 	Refund amount for a given product in the local currency (Enhanced Ecommerce).
		/// </summary>
		public LocalProductRefundAmount LocalProductRefundAmount { get; set; }
		/// <summary>
		/// 	Total refund amount for the transaction in the local currency (Enhanced Ecommerce).
		/// </summary>
		public LocalRefundAmount LocalRefundAmount { get; set; }
		/// <summary>
		/// 	Number of times the product was added to the shopping cart (Enhanced Ecommerce).
		/// </summary>
		public ProductAddsToCart ProductAddsToCart { get; set; }
		/// <summary>
		/// 	Number of times the product was included in the check-out process (Enhanced Ecommerce).
		/// </summary>
		public ProductCheckouts ProductCheckouts { get; set; }
		/// <summary>
		/// 	Number of times users viewed the product-detail page (Enhanced Ecommerce).
		/// </summary>
		public ProductDetailViews ProductDetailViews { get; set; }
		/// <summary>
		/// 	The rate at which users clicked through on the product in a product list (ga:productListClicks / ga:productListViews) - (Enhanced Ecommerce).
		/// </summary>
		public ProductListCTR ProductListCTR { get; set; }
		/// <summary>
		/// 	Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).
		/// </summary>
		public ProductListClicks ProductListClicks { get; set; }
		/// <summary>
		/// 	Number of times the product appeared in a product list (Enhanced Ecommerce).
		/// </summary>
		public ProductListViews ProductListViews { get; set; }
		/// <summary>
		/// 	Total refund amount associated with the product (Enhanced Ecommerce).
		/// </summary>
		public ProductRefundAmount ProductRefundAmount { get; set; }
		/// <summary>
		/// 	Number of times a refund was issued for the product (Enhanced Ecommerce).
		/// </summary>
		public ProductRefunds ProductRefunds { get; set; }
		/// <summary>
		/// 	Number of times the product was removed from shopping cart (Enhanced Ecommerce).
		/// </summary>
		public ProductRemovesFromCart ProductRemovesFromCart { get; set; }
		/// <summary>
		/// 	Average product revenue per purchase (commonly used with Product Coupon Code) (ga:itemRevenue / ga:uniquePurchases) - (Enhanced Ecommerce).
		/// </summary>
		public ProductRevenuePerPurchase ProductRevenuePerPurchase { get; set; }
		/// <summary>
		/// 	Number of product units added to the shopping cart (Enhanced Ecommerce).
		/// </summary>
		public QuantityAddedToCart QuantityAddedToCart { get; set; }
		/// <summary>
		/// 	Number of product units included in check out (Enhanced Ecommerce).
		/// </summary>
		public QuantityCheckedOut QuantityCheckedOut { get; set; }
		/// <summary>
		/// 	Number of product units refunded (Enhanced Ecommerce).
		/// </summary>
		public QuantityRefunded QuantityRefunded { get; set; }
		/// <summary>
		/// 	Number of product units removed from cart (Enhanced Ecommerce).
		/// </summary>
		public QuantityRemovedFromCart QuantityRemovedFromCart { get; set; }
		/// <summary>
		/// 	Quantity of the product being queried.
		/// </summary>
		public QueryProductQuantity QueryProductQuantity { get; set; }
		/// <summary>
		/// 	Currency amount refunded for a transaction (Enhanced Ecommerce).
		/// </summary>
		public RefundAmount RefundAmount { get; set; }
		/// <summary>
		/// 	Quantity of the related product.
		/// </summary>
		public RelatedProductQuantity RelatedProductQuantity { get; set; }
		/// <summary>
		/// 	The total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users.
		/// </summary>
		public RevenuePerUser RevenuePerUser { get; set; }
		/// <summary>
		/// 	The total number of sessions divided by the total number of users.
		/// </summary>
		public SessionsPerUser SessionsPerUser { get; set; }
		/// <summary>
		/// 	Number of refunds that have been issued (Enhanced Ecommerce).
		/// </summary>
		public TotalRefunds TotalRefunds { get; set; }
		/// <summary>
		/// 	The total number of transactions divided by the total number of users.
		/// </summary>
		public TransactionsPerUser TransactionsPerUser { get; set; }
		/// <summary>
		/// 	A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.
		/// </summary>
		public UserType UserType { get; set; }
		/// <summary>
		/// 	The session index for a user. Each session from a unique user will get its own incremental index starting from 1 for the first session. Subsequent sessions do not change previous session indicies. For example, if a certain user has 4 sessions to your website, sessionCount for that user will have 4 distinct values of '1' through '4'.
		/// </summary>
		public SessionCount SessionCount { get; set; }
		/// <summary>
		/// 	The number of days elapsed since users last visited your property. Used to calculate user loyalty.
		/// </summary>
		public DaysSinceLastSession DaysSinceLastSession { get; set; }
		/// <summary>
		/// 	The value provided when you define custom user segments for your property.
		/// </summary>
		public UserDefinedValue UserDefinedValue { get; set; }
		/// <summary>
		/// 	The length of a session measured in seconds and reported in second increments. The value returned is a string.
		/// </summary>
		public SessionDurationBucket SessionDurationBucket { get; set; }
		/// <summary>
		/// 	The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link.
		/// </summary>
		public ReferralPath ReferralPath { get; set; }
		/// <summary>
		/// 	The full referring URL including the hostname and path.
		/// </summary>
		public FullReferrer FullReferrer { get; set; }
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_campaign campaign tracking parameter. When using AdWords autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the value (not set) is used.
		/// </summary>
		public Campaign Campaign { get; set; }
		/// <summary>
		/// 	The source of referrals. When using manual campaign tracking, the value of the utm_source campaign tracking parameter. When using AdWords autotagging, the value is google. Otherwise the domain of the source referring the user (e.g. document.referrer). The value may also contain a port address. If the user arrived without a referrer, the value is (direct)
		/// </summary>
		public Source Source { get; set; }
		/// <summary>
		/// 	The type of referrals. When using manual campaign tracking, the value of the utm_medium campaign tracking parameter. When using AdWords autotagging, the value is ppc. If the user comes from a search engine detected by Google Analytics, the value is organic. If the referrer is not a search engine, the value is referral. If the users came directly to the property, and document.referrer is empty, the value is (none).
		/// </summary>
		public Medium Medium { get; set; }
		/// <summary>
		/// 	Combined values of ga:source and ga:medium.
		/// </summary>
		public SourceMedium SourceMedium { get; set; }
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_term campaign tracking parameter. When using AdWords autotagging or if a user used organic search to reach your property, the keywords used by users to reach your property. Otherwise the value is (not set).
		/// </summary>
		public Keyword Keyword { get; set; }
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_content campaign tracking parameter. When using AdWords autotagging, the first line of the text for your online Ad campaign. If you are using mad libs for your AdWords content, this field displays the keywords you provided for the mad libs keyword match. Otherwise the value is (not set)
		/// </summary>
		public AdContent AdContent { get; set; }
		/// <summary>
		/// 	Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc.
		/// </summary>
		public SocialNetwork SocialNetwork { get; set; }
		/// <summary>
		/// 	Indicates sessions that arrived to the property from a social source. The possible values are Yes or No where the first letter is capitalized.
		/// </summary>
		public HasSocialSourceReferral HasSocialSourceReferral { get; set; }
		/// <summary>
		/// 	The name of your AdWords ad group.
		/// </summary>
		public AdGroup AdGroup { get; set; }
		/// <summary>
		/// 	The location of the advertisement on the hosting page (Top, RHS, or not set).
		/// </summary>
		public AdSlot AdSlot { get; set; }
		/// <summary>
		/// 	The networks used to deliver your ads (Content, Search, Search partners, etc.).
		/// </summary>
		public AdDistributionNetwork AdDistributionNetwork { get; set; }
		/// <summary>
		/// 	The match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content network are identified as "Content network". Details: https://support.google.com/adwords/answer/2472708?hl=en
		/// </summary>
		public AdMatchType AdMatchType { get; set; }
		/// <summary>
		/// 	The match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en
		/// </summary>
		public AdKeywordMatchType AdKeywordMatchType { get; set; }
		/// <summary>
		/// 	The search queries that triggered impressions of your AdWords ads.
		/// </summary>
		public AdMatchedQuery AdMatchedQuery { get; set; }
		/// <summary>
		/// 	The domains where your ads on the content network were placed.
		/// </summary>
		public AdPlacementDomain AdPlacementDomain { get; set; }
		/// <summary>
		/// 	The URLs where your ads on the content network were placed.
		/// </summary>
		public AdPlacementUrl AdPlacementUrl { get; set; }
		/// <summary>
		/// 	Your AdWords ad formats (Text, Image, Flash, Video, etc.).
		/// </summary>
		public AdFormat AdFormat { get; set; }
		/// <summary>
		/// 	How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).
		/// </summary>
		public AdTargetingType AdTargetingType { get; set; }
		/// <summary>
		/// 	How you manage your ads on the content network. Values are Automatic placements or Managed placements.
		/// </summary>
		public AdTargetingOption AdTargetingOption { get; set; }
		/// <summary>
		/// 	The URLs your AdWords ads displayed.
		/// </summary>
		public AdDisplayUrl AdDisplayUrl { get; set; }
		/// <summary>
		/// 	The URLs to which your AdWords ads referred traffic.
		/// </summary>
		public AdDestinationUrl AdDestinationUrl { get; set; }
		/// <summary>
		/// 	A string. Corresponds to AdWords API AccountInfo.customerId.
		/// </summary>
		public AdwordsCustomerId AdwordsCustomerId { get; set; }
		/// <summary>
		/// 	A string. Corresponds to AdWords API Campaign.id.
		/// </summary>
		public AdwordsCampaignId AdwordsCampaignId { get; set; }
		/// <summary>
		/// 	A string. Corresponds to AdWords API AdGroup.id.
		/// </summary>
		public AdwordsAdGroupId AdwordsAdGroupId { get; set; }
		/// <summary>
		/// 	A string. Corresponds to AdWords API Ad.id.
		/// </summary>
		public AdwordsCreativeId AdwordsCreativeId { get; set; }
		/// <summary>
		/// 	A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
		/// </summary>
		public AdwordsCriteriaId AdwordsCriteriaId { get; set; }
		/// <summary>
		/// 	The number of words in the search query.
		/// </summary>
		public AdQueryWordCount AdQueryWordCount { get; set; }
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal completion.
		/// </summary>
		public GoalCompletionLocation GoalCompletionLocation { get; set; }
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal, one step prior to the goal completion location.
		/// </summary>
		public GoalPreviousStep1 GoalPreviousStep1 { get; set; }
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal, two steps prior to the goal completion location.
		/// </summary>
		public GoalPreviousStep2 GoalPreviousStep2 { get; set; }
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal, three steps prior to the goal completion location.
		/// </summary>
		public GoalPreviousStep3 GoalPreviousStep3 { get; set; }
		/// <summary>
		/// 	The names of browsers used by users to your website. For example, Internet Explorer or Firefox.
		/// </summary>
		public Browser Browser { get; set; }
		/// <summary>
		/// 	The browser versions used by users to your website. For example, 2.0.0.14
		/// </summary>
		public BrowserVersion BrowserVersion { get; set; }
		/// <summary>
		/// 	The operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod.
		/// </summary>
		public OperatingSystem OperatingSystem { get; set; }
		/// <summary>
		/// 	The version of the operating system used by your users, such as XP for Windows or PPC for Macintosh.
		/// </summary>
		public OperatingSystemVersion OperatingSystemVersion { get; set; }
		/// <summary>
		/// 	Mobile manufacturer or branded name.
		/// </summary>
		public MobileDeviceBranding MobileDeviceBranding { get; set; }
		/// <summary>
		/// 	Mobile device model.
		/// </summary>
		public MobileDeviceModel MobileDeviceModel { get; set; }
		/// <summary>
		/// 	Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).
		/// </summary>
		public MobileInputSelector MobileInputSelector { get; set; }
		/// <summary>
		/// 	The branding, model, and marketing name used to identify the mobile device.
		/// </summary>
		public MobileDeviceInfo MobileDeviceInfo { get; set; }
		/// <summary>
		/// 	The marketing name used for the mobile device.
		/// </summary>
		public MobileDeviceMarketingName MobileDeviceMarketingName { get; set; }
		/// <summary>
		/// 	The type of device: desktop, tablet, or mobile.
		/// </summary>
		public DeviceCategory DeviceCategory { get; set; }
		/// <summary>
		/// 	The continents of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		public Continent Continent { get; set; }
		/// <summary>
		/// 	The sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe.
		/// </summary>
		public SubContinent SubContinent { get; set; }
		/// <summary>
		/// 	The country of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		public Country Country { get; set; }
		/// <summary>
		/// 	The region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York.
		/// </summary>
		public Region Region { get; set; }
		/// <summary>
		/// 	The Designated Market Area (DMA) from where traffic arrived.
		/// </summary>
		public Metro Metro { get; set; }
		/// <summary>
		/// 	The cities of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		public City City { get; set; }
		/// <summary>
		/// 	The approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values.
		/// </summary>
		public Latitude Latitude { get; set; }
		/// <summary>
		/// 	The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.
		/// </summary>
		public Longitude Longitude { get; set; }
		/// <summary>
		/// 	The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.
		/// </summary>
		public NetworkDomain NetworkDomain { get; set; }
		/// <summary>
		/// 	The name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element.
		/// </summary>
		public NetworkLocation NetworkLocation { get; set; }
		/// <summary>
		/// 	The versions of Flash supported by users' browsers, including minor versions.
		/// </summary>
		public FlashVersion FlashVersion { get; set; }
		/// <summary>
		/// 	Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.
		/// </summary>
		public JavaEnabled JavaEnabled { get; set; }
		/// <summary>
		/// 	The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).
		/// </summary>
		public Language Language { get; set; }
		/// <summary>
		/// 	The color depth of users' monitors, as retrieved from the DOM of the user's browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit.
		/// </summary>
		public ScreenColors ScreenColors { get; set; }
		/// <summary>
		/// 	Source property display name of roll-up properties. This is valid only for roll-up properties.
		/// </summary>
		public SourcePropertyDisplayName SourcePropertyDisplayName { get; set; }
		/// <summary>
		/// 	Source property tracking ID of roll-up properties. This is valid only for roll-up properties.
		/// </summary>
		public SourcePropertyTrackingId SourcePropertyTrackingId { get; set; }
		/// <summary>
		/// 	The screen resolution of users' screens. For example: 1024x738.
		/// </summary>
		public ScreenResolution ScreenResolution { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.)
		/// </summary>
		public SocialActivityEndorsingUrl SocialActivityEndorsingUrl { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the title of the social activity posted by the social network user.
		/// </summary>
		public SocialActivityDisplayName SocialActivityDisplayName { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the content of the social activity posted by the social network user (e.g. The message content of a Google+ post)
		/// </summary>
		public SocialActivityPost SocialActivityPost { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents when the social activity occurred on the social network.
		/// </summary>
		public SocialActivityTimestamp SocialActivityTimestamp { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity.
		/// </summary>
		public SocialActivityUserHandle SocialActivityUserHandle { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL of the photo associated with the user's social network profile.
		/// </summary>
		public SocialActivityUserPhotoUrl SocialActivityUserPhotoUrl { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL of the associated user's social network profile.
		/// </summary>
		public SocialActivityUserProfileUrl SocialActivityUserProfileUrl { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL shared by the associated social network user.
		/// </summary>
		public SocialActivityContentUrl SocialActivityContentUrl { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this is a comma-separated set of tags associated with the social activity.
		/// </summary>
		public SocialActivityTagsSummary SocialActivityTagsSummary { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the type of social action associated with the activity (e.g. vote, comment, +1, etc.).
		/// </summary>
		public SocialActivityAction SocialActivityAction { get; set; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the type of social action and the social network where the activity originated.
		/// </summary>
		public SocialActivityNetworkAction SocialActivityNetworkAction { get; set; }
		/// <summary>
		/// 	The hostname from which the tracking request was made.
		/// </summary>
		public Hostname Hostname { get; set; }
		/// <summary>
		/// 	A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.
		/// </summary>
		public PagePath PagePath { get; set; }
		/// <summary>
		/// 	This dimension rolls up all the page paths in the first hierarchical level in pagePath.
		/// </summary>
		public PagePathLevel1 PagePathLevel1 { get; set; }
		/// <summary>
		/// 	This dimension rolls up all the page paths in the second hierarchical level in pagePath.
		/// </summary>
		public PagePathLevel2 PagePathLevel2 { get; set; }
		/// <summary>
		/// 	This dimension rolls up all the page paths in the third hierarchical level in pagePath.
		/// </summary>
		public PagePathLevel3 PagePathLevel3 { get; set; }
		/// <summary>
		/// 	This dimension rolls up all the page paths into hierarchical levels. Up to 4 pagePath levels maybe specified. All additional levels in the pagePath hierarchy are also rolled up in this dimension.
		/// </summary>
		public PagePathLevel4 PagePathLevel4 { get; set; }
		/// <summary>
		/// 	The title of a page. Keep in mind that multiple pages might have the same page title.
		/// </summary>
		public PageTitle PageTitle { get; set; }
		/// <summary>
		/// 	The first page in a user's session, or landing page.
		/// </summary>
		public LandingPagePath LandingPagePath { get; set; }
		/// <summary>
		/// 	The second page in a user's session.
		/// </summary>
		public SecondPagePath SecondPagePath { get; set; }
		/// <summary>
		/// 	The last page in a user's session, or exit page.
		/// </summary>
		public ExitPagePath ExitPagePath { get; set; }
		/// <summary>
		/// 	A page that was visited before another page on the same property. Typically used with the pagePath dimension.
		/// </summary>
		public PreviousPagePath PreviousPagePath { get; set; }
		/// <summary>
		/// 	The number of pages visited by users during a session. The value is a histogram that counts pageviews across a range of possible values. In this calculation, all sessions will have at least one pageview, and some percentage of sessions will have more.
		/// </summary>
		public PageDepth PageDepth { get; set; }
		/// <summary>
		/// 	A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.
		/// </summary>
		public SearchUsed SearchUsed { get; set; }
		/// <summary>
		/// 	Search terms used by users within your property.
		/// </summary>
		public SearchKeyword SearchKeyword { get; set; }
		/// <summary>
		/// 	Subsequent keyword search terms or strings entered by users after a given initial string search.
		/// </summary>
		public SearchKeywordRefinement SearchKeywordRefinement { get; set; }
		/// <summary>
		/// 	The categories used for the internal search if you have this enabled for your profile. For example, you might have product categories such as electronics, furniture, or clothing.
		/// </summary>
		public SearchCategory SearchCategory { get; set; }
		/// <summary>
		/// 	A page where the user initiated an internal search.
		/// </summary>
		public SearchStartPage SearchStartPage { get; set; }
		/// <summary>
		/// 	The page the user immediately visited after performing an internal search on your site. (Usually the search results page).
		/// </summary>
		public SearchDestinationPage SearchDestinationPage { get; set; }
		/// <summary>
		/// 	A page that the user visited after performing an internal search on your site.
		/// </summary>
		public SearchAfterDestinationPage SearchAfterDestinationPage { get; set; }
		/// <summary>
		/// 	ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.
		/// </summary>
		public AppInstallerId AppInstallerId { get; set; }
		/// <summary>
		/// 	The version of the application.
		/// </summary>
		public AppVersion AppVersion { get; set; }
		/// <summary>
		/// 	The name of the application.
		/// </summary>
		public AppName AppName { get; set; }
		/// <summary>
		/// 	The ID of the application.
		/// </summary>
		public AppId AppId { get; set; }
		/// <summary>
		/// 	The name of the screen.
		/// </summary>
		public ScreenName ScreenName { get; set; }
		/// <summary>
		/// 	The number of screenviews per session reported as a string. Can be useful for historgrams.
		/// </summary>
		public ScreenDepth ScreenDepth { get; set; }
		/// <summary>
		/// 	The name of the first screen viewed.
		/// </summary>
		public LandingScreenName LandingScreenName { get; set; }
		/// <summary>
		/// 	The name of the screen when the user exited the application.
		/// </summary>
		public ExitScreenName ExitScreenName { get; set; }
		/// <summary>
		/// 	The category of the event.
		/// </summary>
		public EventCategory EventCategory { get; set; }
		/// <summary>
		/// 	The action of the event.
		/// </summary>
		public EventAction EventAction { get; set; }
		/// <summary>
		/// 	The label of the event.
		/// </summary>
		public EventLabel EventLabel { get; set; }
		/// <summary>
		/// 	The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.
		/// </summary>
		public TransactionId TransactionId { get; set; }
		/// <summary>
		/// 	Typically used to designate a supplying company or brick and mortar location; product affiliation.
		/// </summary>
		public Affiliation Affiliation { get; set; }
		/// <summary>
		/// 	The number of sessions between users' purchases and the related campaigns that lead to the purchases.
		/// </summary>
		public SessionsToTransaction SessionsToTransaction { get; set; }
		/// <summary>
		/// 	The number of days between users' purchases and the related campaigns that lead to the purchases.
		/// </summary>
		public DaysToTransaction DaysToTransaction { get; set; }
		/// <summary>
		/// 	The product sku for purchased items as you have defined them in your ecommerce tracking application.
		/// </summary>
		public ProductSku ProductSku { get; set; }
		/// <summary>
		/// 	The product name for purchased items as supplied by your ecommerce tracking application.
		/// </summary>
		public ProductName ProductName { get; set; }
		/// <summary>
		/// 	Any product variations (size, color) for purchased items as supplied by your ecommerce application. Not compatible with Enhanced Ecommerce.
		/// </summary>
		public ProductCategory ProductCategory { get; set; }
		/// <summary>
		/// 	The local currency code of the transaction based on ISO 4217 standard.
		/// </summary>
		public CurrencyCode CurrencyCode { get; set; }
		/// <summary>
		/// 	For social interactions, a value representing the social network being tracked.
		/// </summary>
		public SocialInteractionNetwork SocialInteractionNetwork { get; set; }
		/// <summary>
		/// 	For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)
		/// </summary>
		public SocialInteractionAction SocialInteractionAction { get; set; }
		/// <summary>
		/// 	For social interactions, a value representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1)
		/// </summary>
		public SocialInteractionNetworkAction SocialInteractionNetworkAction { get; set; }
		/// <summary>
		/// 	For social interactions, a value representing the URL (or resource) which receives the social network action.
		/// </summary>
		public SocialInteractionTarget SocialInteractionTarget { get; set; }
		/// <summary>
		/// 	Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged".
		/// </summary>
		public SocialEngagementType SocialEngagementType { get; set; }
		/// <summary>
		/// 	A string for categorizing all user timing variables into logical groups for easier reporting purposes.
		/// </summary>
		public UserTimingCategory UserTimingCategory { get; set; }
		/// <summary>
		/// 	The name of the resource's action being tracked.
		/// </summary>
		public UserTimingLabel UserTimingLabel { get; set; }
		/// <summary>
		/// 	A value that can be used to add flexibility in visualizing user timings in the reports.
		/// </summary>
		public UserTimingVariable UserTimingVariable { get; set; }
		/// <summary>
		/// 	The description for the exception.
		/// </summary>
		public ExceptionDescription ExceptionDescription { get; set; }
		/// <summary>
		/// 	The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.
		/// </summary>
		public ExperimentId ExperimentId { get; set; }
		/// <summary>
		/// 	The user-scoped id of the particular variation that the user was exposed to during a content experiment.
		/// </summary>
		public ExperimentVariant ExperimentVariant { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 1 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension1 Dimension1 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 2 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension2 Dimension2 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 3 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension3 Dimension3 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 4 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension4 Dimension4 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 5 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension5 Dimension5 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 6 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension6 Dimension6 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 7 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension7 Dimension7 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 8 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension8 Dimension8 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 9 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension9 Dimension9 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 10 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension10 Dimension10 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 11 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension11 Dimension11 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 12 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension12 Dimension12 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 13 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension13 Dimension13 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 14 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension14 Dimension14 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 15 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension15 Dimension15 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 16 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension16 Dimension16 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 17 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension17 Dimension17 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 18 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension18 Dimension18 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 19 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension19 Dimension19 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 20 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension20 Dimension20 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 21 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension21 Dimension21 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 22 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension22 Dimension22 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 23 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension23 Dimension23 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 24 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension24 Dimension24 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 25 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension25 Dimension25 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 26 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension26 Dimension26 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 27 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension27 Dimension27 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 28 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension28 Dimension28 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 29 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension29 Dimension29 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 30 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension30 Dimension30 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 31 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension31 Dimension31 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 32 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension32 Dimension32 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 33 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension33 Dimension33 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 34 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension34 Dimension34 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 35 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension35 Dimension35 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 36 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension36 Dimension36 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 37 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension37 Dimension37 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 38 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension38 Dimension38 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 39 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension39 Dimension39 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 40 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension40 Dimension40 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 41 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension41 Dimension41 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 42 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension42 Dimension42 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 43 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension43 Dimension43 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 44 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension44 Dimension44 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 45 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension45 Dimension45 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 46 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension46 Dimension46 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 47 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension47 Dimension47 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 48 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension48 Dimension48 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 49 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension49 Dimension49 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 50 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension50 Dimension50 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 51 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension51 Dimension51 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 52 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension52 Dimension52 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 53 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension53 Dimension53 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 54 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension54 Dimension54 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 55 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension55 Dimension55 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 56 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension56 Dimension56 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 57 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension57 Dimension57 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 58 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension58 Dimension58 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 59 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension59 Dimension59 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 60 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension60 Dimension60 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 61 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension61 Dimension61 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 62 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension62 Dimension62 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 63 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension63 Dimension63 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 64 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension64 Dimension64 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 65 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension65 Dimension65 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 66 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension66 Dimension66 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 67 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension67 Dimension67 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 68 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension68 Dimension68 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 69 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension69 Dimension69 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 70 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension70 Dimension70 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 71 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension71 Dimension71 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 72 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension72 Dimension72 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 73 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension73 Dimension73 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 74 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension74 Dimension74 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 75 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension75 Dimension75 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 76 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension76 Dimension76 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 77 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension77 Dimension77 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 78 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension78 Dimension78 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 79 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension79 Dimension79 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 80 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension80 Dimension80 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 81 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension81 Dimension81 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 82 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension82 Dimension82 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 83 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension83 Dimension83 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 84 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension84 Dimension84 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 85 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension85 Dimension85 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 86 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension86 Dimension86 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 87 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension87 Dimension87 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 88 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension88 Dimension88 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 89 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension89 Dimension89 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 90 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension90 Dimension90 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 91 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension91 Dimension91 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 92 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension92 Dimension92 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 93 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension93 Dimension93 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 94 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension94 Dimension94 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 95 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension95 Dimension95 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 96 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension96 Dimension96 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 97 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension97 Dimension97 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 98 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension98 Dimension98 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 99 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension99 Dimension99 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 100 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension100 Dimension100 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 101 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension101 Dimension101 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 102 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension102 Dimension102 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 103 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension103 Dimension103 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 104 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension104 Dimension104 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 105 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension105 Dimension105 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 106 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension106 Dimension106 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 107 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension107 Dimension107 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 108 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension108 Dimension108 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 109 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension109 Dimension109 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 110 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension110 Dimension110 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 111 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension111 Dimension111 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 112 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension112 Dimension112 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 113 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension113 Dimension113 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 114 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension114 Dimension114 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 115 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension115 Dimension115 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 116 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension116 Dimension116 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 117 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension117 Dimension117 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 118 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension118 Dimension118 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 119 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension119 Dimension119 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 120 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension120 Dimension120 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 121 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension121 Dimension121 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 122 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension122 Dimension122 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 123 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension123 Dimension123 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 124 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension124 Dimension124 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 125 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension125 Dimension125 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 126 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension126 Dimension126 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 127 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension127 Dimension127 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 128 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension128 Dimension128 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 129 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension129 Dimension129 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 130 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension130 Dimension130 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 131 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension131 Dimension131 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 132 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension132 Dimension132 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 133 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension133 Dimension133 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 134 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension134 Dimension134 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 135 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension135 Dimension135 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 136 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension136 Dimension136 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 137 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension137 Dimension137 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 138 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension138 Dimension138 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 139 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension139 Dimension139 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 140 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension140 Dimension140 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 141 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension141 Dimension141 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 142 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension142 Dimension142 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 143 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension143 Dimension143 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 144 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension144 Dimension144 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 145 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension145 Dimension145 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 146 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension146 Dimension146 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 147 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension147 Dimension147 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 148 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension148 Dimension148 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 149 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension149 Dimension149 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 150 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension150 Dimension150 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 151 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension151 Dimension151 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 152 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension152 Dimension152 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 153 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension153 Dimension153 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 154 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension154 Dimension154 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 155 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension155 Dimension155 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 156 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension156 Dimension156 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 157 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension157 Dimension157 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 158 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension158 Dimension158 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 159 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension159 Dimension159 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 160 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension160 Dimension160 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 161 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension161 Dimension161 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 162 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension162 Dimension162 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 163 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension163 Dimension163 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 164 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension164 Dimension164 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 165 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension165 Dimension165 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 166 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension166 Dimension166 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 167 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension167 Dimension167 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 168 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension168 Dimension168 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 169 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension169 Dimension169 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 170 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension170 Dimension170 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 171 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension171 Dimension171 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 172 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension172 Dimension172 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 173 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension173 Dimension173 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 174 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension174 Dimension174 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 175 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension175 Dimension175 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 176 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension176 Dimension176 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 177 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension177 Dimension177 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 178 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension178 Dimension178 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 179 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension179 Dimension179 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 180 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension180 Dimension180 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 181 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension181 Dimension181 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 182 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension182 Dimension182 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 183 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension183 Dimension183 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 184 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension184 Dimension184 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 185 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension185 Dimension185 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 186 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension186 Dimension186 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 187 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension187 Dimension187 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 188 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension188 Dimension188 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 189 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension189 Dimension189 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 190 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension190 Dimension190 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 191 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension191 Dimension191 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 192 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension192 Dimension192 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 193 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension193 Dimension193 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 194 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension194 Dimension194 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 195 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension195 Dimension195 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 196 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension196 Dimension196 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 197 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension197 Dimension197 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 198 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension198 Dimension198 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 199 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension199 Dimension199 { get; set; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 200 refers the number/index of the custom dimension.
		/// </summary>
		public Dimension200 Dimension200 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName1 CustomVarName1 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName2 CustomVarName2 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName3 CustomVarName3 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName4 CustomVarName4 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName5 CustomVarName5 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName6 CustomVarName6 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName7 CustomVarName7 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName8 CustomVarName8 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName9 CustomVarName9 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName10 CustomVarName10 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName11 CustomVarName11 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName12 CustomVarName12 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName13 CustomVarName13 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName14 CustomVarName14 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName15 CustomVarName15 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName16 CustomVarName16 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName17 CustomVarName17 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName18 CustomVarName18 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName19 CustomVarName19 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName20 CustomVarName20 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName21 CustomVarName21 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName22 CustomVarName22 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName23 CustomVarName23 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName24 CustomVarName24 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName25 CustomVarName25 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName26 CustomVarName26 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName27 CustomVarName27 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName28 CustomVarName28 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName29 CustomVarName29 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName30 CustomVarName30 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName31 CustomVarName31 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName32 CustomVarName32 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName33 CustomVarName33 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName34 CustomVarName34 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName35 CustomVarName35 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName36 CustomVarName36 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName37 CustomVarName37 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName38 CustomVarName38 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName39 CustomVarName39 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName40 CustomVarName40 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName41 CustomVarName41 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName42 CustomVarName42 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName43 CustomVarName43 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName44 CustomVarName44 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName45 CustomVarName45 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName46 CustomVarName46 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName47 CustomVarName47 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName48 CustomVarName48 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName49 CustomVarName49 { get; set; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		public CustomVarName50 CustomVarName50 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue1 CustomVarValue1 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue2 CustomVarValue2 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue3 CustomVarValue3 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue4 CustomVarValue4 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue5 CustomVarValue5 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue6 CustomVarValue6 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue7 CustomVarValue7 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue8 CustomVarValue8 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue9 CustomVarValue9 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue10 CustomVarValue10 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue11 CustomVarValue11 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue12 CustomVarValue12 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue13 CustomVarValue13 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue14 CustomVarValue14 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue15 CustomVarValue15 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue16 CustomVarValue16 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue17 CustomVarValue17 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue18 CustomVarValue18 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue19 CustomVarValue19 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue20 CustomVarValue20 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue21 CustomVarValue21 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue22 CustomVarValue22 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue23 CustomVarValue23 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue24 CustomVarValue24 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue25 CustomVarValue25 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue26 CustomVarValue26 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue27 CustomVarValue27 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue28 CustomVarValue28 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue29 CustomVarValue29 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue30 CustomVarValue30 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue31 CustomVarValue31 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue32 CustomVarValue32 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue33 CustomVarValue33 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue34 CustomVarValue34 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue35 CustomVarValue35 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue36 CustomVarValue36 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue37 CustomVarValue37 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue38 CustomVarValue38 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue39 CustomVarValue39 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue40 CustomVarValue40 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue41 CustomVarValue41 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue42 CustomVarValue42 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue43 CustomVarValue43 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue44 CustomVarValue44 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue45 CustomVarValue45 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue46 CustomVarValue46 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue47 CustomVarValue47 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue48 CustomVarValue48 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue49 CustomVarValue49 { get; set; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		public CustomVarValue50 CustomVarValue50 { get; set; }
		/// <summary>
		/// 	The date of the session formatted as YYYYMMDD.
		/// </summary>
		public Date Date { get; set; }
		/// <summary>
		/// 	The year of the session. A four-digit year from 2005 to the current year.
		/// </summary>
		public Year Year { get; set; }
		/// <summary>
		/// 	The month of the session. A two digit integer from 01 to 12.
		/// </summary>
		public Month Month { get; set; }
		/// <summary>
		/// 	The week of the session. A two-digit number from 01 to 53. Each week starts on Sunday.
		/// </summary>
		public Week Week { get; set; }
		/// <summary>
		/// 	The day of the month. A two-digit number from 01 to 31.
		/// </summary>
		public Day Day { get; set; }
		/// <summary>
		/// 	A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This value is also corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone follows daylight savings time, there will be an apparent bump in the number of sessions during the change-over hour (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero sessions will occur at the opposite changeover. (Google Analytics does not track user time more precisely than hours.)
		/// </summary>
		public Hour Hour { get; set; }
		/// <summary>
		/// 	Returns the minute in the hour. The possible values are between 00 and 59.
		/// </summary>
		public Minute Minute { get; set; }
		/// <summary>
		/// 	Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.
		/// </summary>
		public NthMonth NthMonth { get; set; }
		/// <summary>
		/// 	Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries.
		/// </summary>
		public NthWeek NthWeek { get; set; }
		/// <summary>
		/// 	Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on.
		/// </summary>
		public NthDay NthDay { get; set; }
		/// <summary>
		/// 	Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.
		/// </summary>
		public NthMinute NthMinute { get; set; }
		/// <summary>
		/// 	The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).
		/// </summary>
		public DayOfWeek DayOfWeek { get; set; }
		/// <summary>
		/// 	The name of the day of the week (in English).
		/// </summary>
		public DayOfWeekName DayOfWeekName { get; set; }
		/// <summary>
		/// 	Combined values of ga:date and ga:hour.
		/// </summary>
		public DateHour DateHour { get; set; }
		/// <summary>
		/// 	Combined values of ga:year and ga:month.
		/// </summary>
		public YearMonth YearMonth { get; set; }
		/// <summary>
		/// 	Combined values of ga:year and ga:week.
		/// </summary>
		public YearWeek YearWeek { get; set; }
		/// <summary>
		/// 	The ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoWeek should only be used with ga:isoYear since ga:year represents gregorian calendar.
		/// </summary>
		public IsoWeek IsoWeek { get; set; }
		/// <summary>
		/// 	The ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.
		/// </summary>
		public IsoYear IsoYear { get; set; }
		/// <summary>
		/// 	Combined values of ga:isoYear and ga:isoWeek.
		/// </summary>
		public IsoYearIsoWeek IsoYearIsoWeek { get; set; }
		/// <summary>
		/// 	DCM ad name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickAd DcmClickAd { get; set; }
		/// <summary>
		/// 	DCM ad ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickAdId DcmClickAdId { get; set; }
		/// <summary>
		/// 	DCM ad type name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickAdType DcmClickAdType { get; set; }
		/// <summary>
		/// 	DCM ad type ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickAdTypeId DcmClickAdTypeId { get; set; }
		/// <summary>
		/// 	DCM advertiser name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickAdvertiser DcmClickAdvertiser { get; set; }
		/// <summary>
		/// 	DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickAdvertiserId DcmClickAdvertiserId { get; set; }
		/// <summary>
		/// 	DCM campaign name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickCampaign DcmClickCampaign { get; set; }
		/// <summary>
		/// 	DCM campaign ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickCampaignId DcmClickCampaignId { get; set; }
		/// <summary>
		/// 	DCM creative ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickCreativeId DcmClickCreativeId { get; set; }
		/// <summary>
		/// 	DCM creative name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickCreative DcmClickCreative { get; set; }
		/// <summary>
		/// 	DCM rendering ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickRenderingId DcmClickRenderingId { get; set; }
		/// <summary>
		/// 	DCM creative type name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickCreativeType DcmClickCreativeType { get; set; }
		/// <summary>
		/// 	DCM creative type ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickCreativeTypeId DcmClickCreativeTypeId { get; set; }
		/// <summary>
		/// 	DCM creative version of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickCreativeVersion DcmClickCreativeVersion { get; set; }
		/// <summary>
		/// 	Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickSite DcmClickSite { get; set; }
		/// <summary>
		/// 	DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickSiteId DcmClickSiteId { get; set; }
		/// <summary>
		/// 	DCM site placement name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickSitePlacement DcmClickSitePlacement { get; set; }
		/// <summary>
		/// 	DCM site placement ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickSitePlacementId DcmClickSitePlacementId { get; set; }
		/// <summary>
		/// 	DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DcmClickSpotId DcmClickSpotId { get; set; }
		/// <summary>
		/// 	DCM Floodlight activity name associated with the floodlight conversion (premium only).
		/// </summary>
		public DcmFloodlightActivity DcmFloodlightActivity { get; set; }
		/// <summary>
		/// 	DCM Floodlight activity name and group name associated with the floodlight conversion (premium only).
		/// </summary>
		public DcmFloodlightActivityAndGroup DcmFloodlightActivityAndGroup { get; set; }
		/// <summary>
		/// 	DCM Floodlight activity group name associated with the floodlight conversion (premium only).
		/// </summary>
		public DcmFloodlightActivityGroup DcmFloodlightActivityGroup { get; set; }
		/// <summary>
		/// 	DCM Floodlight activity group ID associated with the floodlight conversion (premium only).
		/// </summary>
		public DcmFloodlightActivityGroupId DcmFloodlightActivityGroupId { get; set; }
		/// <summary>
		/// 	DCM Floodlight activity ID associated with the floodlight conversion (premium only).
		/// </summary>
		public DcmFloodlightActivityId DcmFloodlightActivityId { get; set; }
		/// <summary>
		/// 	DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).
		/// </summary>
		public DcmFloodlightAdvertiserId DcmFloodlightAdvertiserId { get; set; }
		/// <summary>
		/// 	DCM Floodlight configuration ID associated with the floodlight conversion (premium only).
		/// </summary>
		public DcmFloodlightSpotId DcmFloodlightSpotId { get; set; }
		/// <summary>
		/// 	DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventAd DcmLastEventAd { get; set; }
		/// <summary>
		/// 	DCM ad ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventAdId DcmLastEventAdId { get; set; }
		/// <summary>
		/// 	DCM ad type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventAdType DcmLastEventAdType { get; set; }
		/// <summary>
		/// 	DCM ad type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventAdTypeId DcmLastEventAdTypeId { get; set; }
		/// <summary>
		/// 	DCM advertiser name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventAdvertiser DcmLastEventAdvertiser { get; set; }
		/// <summary>
		/// 	DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventAdvertiserId DcmLastEventAdvertiserId { get; set; }
		/// <summary>
		/// 	There are two possible values: ClickThrough and ViewThrough. If the last DCM event associated with the Google Analytics session was a click, then the value will be ClickThrough. If the last DCM event associated with the Google Analytics session was an ad impression, then the value will be ViewThrough (premium only).
		/// </summary>
		public DcmLastEventAttributionType DcmLastEventAttributionType { get; set; }
		/// <summary>
		/// 	DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventCampaign DcmLastEventCampaign { get; set; }
		/// <summary>
		/// 	DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventCampaignId DcmLastEventCampaignId { get; set; }
		/// <summary>
		/// 	DCM creative ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventCreativeId DcmLastEventCreativeId { get; set; }
		/// <summary>
		/// 	DCM creative name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventCreative DcmLastEventCreative { get; set; }
		/// <summary>
		/// 	DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventRenderingId DcmLastEventRenderingId { get; set; }
		/// <summary>
		/// 	DCM creative type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventCreativeType DcmLastEventCreativeType { get; set; }
		/// <summary>
		/// 	DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventCreativeTypeId DcmLastEventCreativeTypeId { get; set; }
		/// <summary>
		/// 	DCM creative version of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventCreativeVersion DcmLastEventCreativeVersion { get; set; }
		/// <summary>
		/// 	Site name where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventSite DcmLastEventSite { get; set; }
		/// <summary>
		/// 	DCM site ID where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventSiteId DcmLastEventSiteId { get; set; }
		/// <summary>
		/// 	DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventSitePlacement DcmLastEventSitePlacement { get; set; }
		/// <summary>
		/// 	DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventSitePlacementId DcmLastEventSitePlacementId { get; set; }
		/// <summary>
		/// 	DCM Floodlight configuration ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DcmLastEventSpotId DcmLastEventSpotId { get; set; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		public LandingContentGroup1 LandingContentGroup1 { get; set; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		public LandingContentGroup2 LandingContentGroup2 { get; set; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		public LandingContentGroup3 LandingContentGroup3 { get; set; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		public LandingContentGroup4 LandingContentGroup4 { get; set; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		public LandingContentGroup5 LandingContentGroup5 { get; set; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		public PreviousContentGroup1 PreviousContentGroup1 { get; set; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		public PreviousContentGroup2 PreviousContentGroup2 { get; set; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		public PreviousContentGroup3 PreviousContentGroup3 { get; set; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		public PreviousContentGroup4 PreviousContentGroup4 { get; set; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		public PreviousContentGroup5 PreviousContentGroup5 { get; set; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		public ContentGroup1 ContentGroup1 { get; set; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		public ContentGroup2 ContentGroup2 { get; set; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		public ContentGroup3 ContentGroup3 { get; set; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		public ContentGroup4 ContentGroup4 { get; set; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		public ContentGroup5 ContentGroup5 { get; set; }
		/// <summary>
		/// 	Age bracket of user.
		/// </summary>
		public UserAgeBracket UserAgeBracket { get; set; }
		/// <summary>
		/// 	Gender of user.
		/// </summary>
		public UserGender UserGender { get; set; }
		/// <summary>
		/// 	Indicates that users are more likely to be interested in learning about the specified category, and more likely to be ready to purchase.
		/// </summary>
		public InterestOtherCategory InterestOtherCategory { get; set; }
		/// <summary>
		/// 	Indicates that users are more likely to be interested in learning about the specified category.
		/// </summary>
		public InterestAffinityCategory InterestAffinityCategory { get; set; }
		/// <summary>
		/// 	Indicates that users are more likely to be ready to purchase products or services in the specified category.
		/// </summary>
		public InterestInMarketCategory InterestInMarketCategory { get; set; }
		/// <summary>
		/// 	The browser size used by users to your website. For example, 1024x768.
		/// </summary>
		public BrowserSize BrowserSize { get; set; }
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_id campaign tracking parameter.
		/// </summary>
		public CampaignCode CampaignCode { get; set; }
		/// <summary>
		/// 	The default channel grouping that is shared within the View (Profile).
		/// </summary>
		public ChannelGrouping ChannelGrouping { get; set; }
		/// <summary>
		/// 	User options specified during the checkout process, e.g., FedEx, DHL, UPS for delivery options or Visa, MasterCard, AmEx for payment options. This dimension should be used along with ga:shoppingStage (Enhanced Ecommerce).
		/// </summary>
		public CheckoutOptions CheckoutOptions { get; set; }
		/// <summary>
		/// 	The city IDs of users, derived from IP addresses or Geographical IDs. The city IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
		/// </summary>
		public CityId CityId { get; set; }
		/// <summary>
		/// 	Correlation Model ID for related products.
		/// </summary>
		public CorrelationModelId CorrelationModelId { get; set; }
		/// <summary>
		/// 	The country ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-1 alpha-2 code.
		/// </summary>
		public CountryIsoCode CountryIsoCode { get; set; }
		/// <summary>
		/// 	The data source of a hit. By default, hits sent from ga.js and analytics.js are reported as "web". Hits sent from the mobile SDKs are reported as "app". These values can be overridden in the Measurement Protocol.
		/// </summary>
		public DataSource DataSource { get; set; }
		/// <summary>
		/// 	The creative content designed for a promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionCreative InternalPromotionCreative { get; set; }
		/// <summary>
		/// 	The ID of the promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionId InternalPromotionId { get; set; }
		/// <summary>
		/// 	The name of the promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionName InternalPromotionName { get; set; }
		/// <summary>
		/// 	The position of the promotion on the web page or application screen (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionPosition InternalPromotionPosition { get; set; }
		/// <summary>
		/// 	Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.
		/// </summary>
		public IsTrueViewVideoAd IsTrueViewVideoAd { get; set; }
		/// <summary>
		/// 	Index for each hour in the specified date range. Index for the first hour of first day (i.e., start-date) in the date range is 0, 1 for the next hour, and so on.
		/// </summary>
		public NthHour NthHour { get; set; }
		/// <summary>
		/// 	Code for the order-level coupon (Enhanced Ecommerce).
		/// </summary>
		public OrderCouponCode OrderCouponCode { get; set; }
		/// <summary>
		/// 	The brand name under which the product is sold (Enhanced Ecommerce).
		/// </summary>
		public ProductBrand ProductBrand { get; set; }
		/// <summary>
		/// 	The hierarchical category in which the product is classified (Enhanced Ecommerce).
		/// </summary>
		public ProductCategoryHierarchy ProductCategoryHierarchy { get; set; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		public ProductCategoryLevel1 ProductCategoryLevel1 { get; set; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		public ProductCategoryLevel2 ProductCategoryLevel2 { get; set; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		public ProductCategoryLevel3 ProductCategoryLevel3 { get; set; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		public ProductCategoryLevel4 ProductCategoryLevel4 { get; set; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		public ProductCategoryLevel5 ProductCategoryLevel5 { get; set; }
		/// <summary>
		/// 	Code for the product-level coupon (Enhanced Ecommerce).
		/// </summary>
		public ProductCouponCode ProductCouponCode { get; set; }
		/// <summary>
		/// 	The name of the product list in which the product appears (Enhanced Ecommerce).
		/// </summary>
		public ProductListName ProductListName { get; set; }
		/// <summary>
		/// 	The position of the product in the product list (Enhanced Ecommerce).
		/// </summary>
		public ProductListPosition ProductListPosition { get; set; }
		/// <summary>
		/// 	The specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce).
		/// </summary>
		public ProductVariant ProductVariant { get; set; }
		/// <summary>
		/// 	ID of the product being queried.
		/// </summary>
		public QueryProductId QueryProductId { get; set; }
		/// <summary>
		/// 	Name of the product being queried.
		/// </summary>
		public QueryProductName QueryProductName { get; set; }
		/// <summary>
		/// 	Variation of the product being queried.
		/// </summary>
		public QueryProductVariation QueryProductVariation { get; set; }
		/// <summary>
		/// 	The region ID of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York. The region IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
		/// </summary>
		public RegionId RegionId { get; set; }
		/// <summary>
		/// 	The region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code.
		/// </summary>
		public RegionIsoCode RegionIsoCode { get; set; }
		/// <summary>
		/// 	ID of the related product.
		/// </summary>
		public RelatedProductId RelatedProductId { get; set; }
		/// <summary>
		/// 	Name of the related product.
		/// </summary>
		public RelatedProductName RelatedProductName { get; set; }
		/// <summary>
		/// 	Variation of the related product.
		/// </summary>
		public RelatedProductVariation RelatedProductVariation { get; set; }
		/// <summary>
		/// 	Various stages of the shopping experience that users completed in a session, e.g., PRODUCT_VIEW, ADD_TO_CART, CHECKOUT, etc. (Enhanced Ecommerce).
		/// </summary>
		public ShoppingStage ShoppingStage { get; set; }
		/// <summary>
		/// 	The sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code.
		/// </summary>
		public SubContinentCode SubContinentCode { get; set; }
	}
}

