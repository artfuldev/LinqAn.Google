using LinqAn.Google.Metrics;
using LinqAn.Google.Dimensions;

namespace LinqAn.Google.Records
{
	public interface IRecord
	{
		/// <summary>
		 /// 	The id of the view to query.
		/// </summary>
		uint ViewId { get; }
		/// <summary>
		 /// 	The date of the record to query.
		/// </summary>
		System.DateTime RecordDate { get; }
		/// <summary>
		/// 	The total number of users for the requested time period.
		/// </summary>
		Users Users { get; }
		/// <summary>
		/// 	The number of users whose session was marked as a first-time session.
		/// </summary>
		NewUsers NewUsers { get; }
		/// <summary>
		/// 	The percentage of sessions by people who had never visited your property before.
		/// </summary>
		PercentNewSessions PercentNewSessions { get; }
		/// <summary>
		/// 	Total number of 1-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 1 day period ending on the given date.
		/// </summary>
		OneDayUsers OneDayUsers { get; }
		/// <summary>
		/// 	Total number of 7-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 7 day period ending on the given date.
		/// </summary>
		SevenDayUsers SevenDayUsers { get; }
		/// <summary>
		/// 	Total number of 14-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date.
		/// </summary>
		FourteenDayUsers FourteenDayUsers { get; }
		/// <summary>
		/// 	Total number of 30-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 30 day period ending on the given date.
		/// </summary>
		ThirtyDayUsers ThirtyDayUsers { get; }
		/// <summary>
		/// 	The total number of sessions.
		/// </summary>
		Sessions Sessions { get; }
		/// <summary>
		/// 	The total number of single page (or single engagement hit) sessions for your property.
		/// </summary>
		Bounces Bounces { get; }
		/// <summary>
		/// 	The percentage of single-page session (i.e., session in which the person left your property from the first page).
		/// </summary>
		BounceRate BounceRate { get; }
		/// <summary>
		/// 	The total duration of user sessions represented in total seconds.
		/// </summary>
		SessionDuration SessionDuration { get; }
		/// <summary>
		/// 	The average duration of user sessions represented in total seconds.
		/// </summary>
		AvgSessionDuration AvgSessionDuration { get; }
		/// <summary>
		/// 	The number of organic searches that happened within a session. This metric is search engine agnostic.
		/// </summary>
		OrganicSearches OrganicSearches { get; }
		/// <summary>
		/// 	Total number of campaign impressions.
		/// </summary>
		Impressions Impressions { get; }
		/// <summary>
		/// 	The total number of times users have clicked on an ad to reach your property.
		/// </summary>
		AdClicks AdClicks { get; }
		/// <summary>
		/// 	Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account.
		/// </summary>
		AdCost AdCost { get; }
		/// <summary>
		/// 	Cost per thousand impressions.
		/// </summary>
		CPM CPM { get; }
		/// <summary>
		/// 	Cost to advertiser per click.
		/// </summary>
		CPC CPC { get; }
		/// <summary>
		/// 	Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared).
		/// </summary>
		CTR CTR { get; }
		/// <summary>
		/// 	The cost per transaction for your property.
		/// </summary>
		CostPerTransaction CostPerTransaction { get; }
		/// <summary>
		/// 	The cost per goal conversion for your property.
		/// </summary>
		CostPerGoalConversion CostPerGoalConversion { get; }
		/// <summary>
		/// 	The cost per conversion (including ecommerce and goal conversions) for your property.
		/// </summary>
		CostPerConversion CostPerConversion { get; }
		/// <summary>
		/// 	RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads.
		/// </summary>
		RPC RPC { get; }
		/// <summary>
		/// 	Return On Ad Spend (ROAS) is the total transaction revenue and goal value divided by derived advertising cost.
		/// </summary>
		ROAS ROAS { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal1Starts Goal1Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal2Starts Goal2Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal3Starts Goal3Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal4Starts Goal4Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal5Starts Goal5Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal6Starts Goal6Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal7Starts Goal7Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal8Starts Goal8Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal9Starts Goal9Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal10Starts Goal10Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal11Starts Goal11Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal12Starts Goal12Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal13Starts Goal13Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal14Starts Goal14Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal15Starts Goal15Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal16Starts Goal16Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal17Starts Goal17Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal18Starts Goal18Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal19Starts Goal19Starts { get; }
		/// <summary>
		/// 	The total number of starts for the requested goal number.
		/// </summary>
		Goal20Starts Goal20Starts { get; }
		/// <summary>
		/// 	The total number of starts for all goals defined for your profile.
		/// </summary>
		GoalStartsAll GoalStartsAll { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal1Completions Goal1Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal2Completions Goal2Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal3Completions Goal3Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal4Completions Goal4Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal5Completions Goal5Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal6Completions Goal6Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal7Completions Goal7Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal8Completions Goal8Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal9Completions Goal9Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal10Completions Goal10Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal11Completions Goal11Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal12Completions Goal12Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal13Completions Goal13Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal14Completions Goal14Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal15Completions Goal15Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal16Completions Goal16Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal17Completions Goal17Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal18Completions Goal18Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal19Completions Goal19Completions { get; }
		/// <summary>
		/// 	The total number of completions for the requested goal number.
		/// </summary>
		Goal20Completions Goal20Completions { get; }
		/// <summary>
		/// 	The total number of completions for all goals defined for your profile.
		/// </summary>
		GoalCompletionsAll GoalCompletionsAll { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal1Value Goal1Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal2Value Goal2Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal3Value Goal3Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal4Value Goal4Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal5Value Goal5Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal6Value Goal6Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal7Value Goal7Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal8Value Goal8Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal9Value Goal9Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal10Value Goal10Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal11Value Goal11Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal12Value Goal12Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal13Value Goal13Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal14Value Goal14Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal15Value Goal15Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal16Value Goal16Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal17Value Goal17Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal18Value Goal18Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal19Value Goal19Value { get; }
		/// <summary>
		/// 	The total numeric value for the requested goal number.
		/// </summary>
		Goal20Value Goal20Value { get; }
		/// <summary>
		/// 	The total numeric value for all goals defined for your profile.
		/// </summary>
		GoalValueAll GoalValueAll { get; }
		/// <summary>
		/// 	The average goal value of a session.
		/// </summary>
		GoalValuePerSession GoalValuePerSession { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal1ConversionRate Goal1ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal2ConversionRate Goal2ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal3ConversionRate Goal3ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal4ConversionRate Goal4ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal5ConversionRate Goal5ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal6ConversionRate Goal6ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal7ConversionRate Goal7ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal8ConversionRate Goal8ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal9ConversionRate Goal9ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal10ConversionRate Goal10ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal11ConversionRate Goal11ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal12ConversionRate Goal12ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal13ConversionRate Goal13ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal14ConversionRate Goal14ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal15ConversionRate Goal15ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal16ConversionRate Goal16ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal17ConversionRate Goal17ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal18ConversionRate Goal18ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal19ConversionRate Goal19ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
		/// </summary>
		Goal20ConversionRate Goal20ConversionRate { get; }
		/// <summary>
		/// 	The percentage of sessions which resulted in a conversion to at least one of your goals.
		/// </summary>
		GoalConversionRateAll GoalConversionRateAll { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal1Abandons Goal1Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal2Abandons Goal2Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal3Abandons Goal3Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal4Abandons Goal4Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal5Abandons Goal5Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal6Abandons Goal6Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal7Abandons Goal7Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal8Abandons Goal8Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal9Abandons Goal9Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal10Abandons Goal10Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal11Abandons Goal11Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal12Abandons Goal12Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal13Abandons Goal13Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal14Abandons Goal14Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal15Abandons Goal15Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal16Abandons Goal16Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal17Abandons Goal17Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal18Abandons Goal18Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal19Abandons Goal19Abandons { get; }
		/// <summary>
		/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
		/// </summary>
		Goal20Abandons Goal20Abandons { get; }
		/// <summary>
		/// 	The overall number of times users started goals without actually completing them.
		/// </summary>
		GoalAbandonsAll GoalAbandonsAll { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal1AbandonRate Goal1AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal2AbandonRate Goal2AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal3AbandonRate Goal3AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal4AbandonRate Goal4AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal5AbandonRate Goal5AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal6AbandonRate Goal6AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal7AbandonRate Goal7AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal8AbandonRate Goal8AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal9AbandonRate Goal9AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal10AbandonRate Goal10AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal11AbandonRate Goal11AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal12AbandonRate Goal12AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal13AbandonRate Goal13AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal14AbandonRate Goal14AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal15AbandonRate Goal15AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal16AbandonRate Goal16AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal17AbandonRate Goal17AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal18AbandonRate Goal18AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal19AbandonRate Goal19AbandonRate { get; }
		/// <summary>
		/// 	The rate at which the requested goal number was abandoned.
		/// </summary>
		Goal20AbandonRate Goal20AbandonRate { get; }
		/// <summary>
		/// 	The rate at which goals were abandoned.
		/// </summary>
		GoalAbandonRateAll GoalAbandonRateAll { get; }
		/// <summary>
		/// 	The total number of activities where a content URL was shared / mentioned on a social data hub partner network.
		/// </summary>
		SocialActivities SocialActivities { get; }
		/// <summary>
		/// 	The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).
		/// </summary>
		PageValue PageValue { get; }
		/// <summary>
		/// 	The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath
		/// </summary>
		Entrances Entrances { get; }
		/// <summary>
		/// 	The percentage of pageviews in which this page was the entrance.
		/// </summary>
		EntranceRate EntranceRate { get; }
		/// <summary>
		/// 	The total number of pageviews for your property.
		/// </summary>
		Pageviews Pageviews { get; }
		/// <summary>
		/// 	The average number of pages viewed during a session, including repeated views of a single page.
		/// </summary>
		PageviewsPerSession PageviewsPerSession { get; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		ContentGroupUniqueViews1 ContentGroupUniqueViews1 { get; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		ContentGroupUniqueViews2 ContentGroupUniqueViews2 { get; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		ContentGroupUniqueViews3 ContentGroupUniqueViews3 { get; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		ContentGroupUniqueViews4 ContentGroupUniqueViews4 { get; }
		/// <summary>
		/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		ContentGroupUniqueViews5 ContentGroupUniqueViews5 { get; }
		/// <summary>
		/// 	The number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		UniquePageviews UniquePageviews { get; }
		/// <summary>
		/// 	How long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.
		/// </summary>
		TimeOnPage TimeOnPage { get; }
		/// <summary>
		/// 	The average amount of time users spent viewing this page or a set of pages.
		/// </summary>
		AvgTimeOnPage AvgTimeOnPage { get; }
		/// <summary>
		/// 	The number of exits from your property.
		/// </summary>
		Exits Exits { get; }
		/// <summary>
		/// 	The percentage of exits from your property that occurred out of the total page views.
		/// </summary>
		ExitRate ExitRate { get; }
		/// <summary>
		/// 	The number of times a search result page was viewed after performing a search.
		/// </summary>
		SearchResultViews SearchResultViews { get; }
		/// <summary>
		/// 	The total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once.
		/// </summary>
		SearchUniques SearchUniques { get; }
		/// <summary>
		/// 	The average number of times people viewed a search results page after performing a search.
		/// </summary>
		AvgSearchResultViews AvgSearchResultViews { get; }
		/// <summary>
		/// 	The total number of sessions that included an internal search
		/// </summary>
		SearchSessions SearchSessions { get; }
		/// <summary>
		/// 	The percentage of sessions with search.
		/// </summary>
		PercentSessionsWithSearch PercentSessionsWithSearch { get; }
		/// <summary>
		/// 	The total number of subsequent page views made after a use of your internal search feature.
		/// </summary>
		SearchDepth SearchDepth { get; }
		/// <summary>
		/// 	The average number of pages people viewed after performing a search.
		/// </summary>
		AvgSearchDepth AvgSearchDepth { get; }
		/// <summary>
		/// 	The total number of times a refinement (transition) occurs between internal search keywords within a session. For example if the sequence of keywords is: "shoes", "shoes", "pants", "pants", this metric will be one because the transition between "shoes" and "pants" is different.
		/// </summary>
		SearchRefinements SearchRefinements { get; }
		/// <summary>
		/// 	The percentage of number of times a refinement (i.e., transition) occurs between internal search keywords within a session.
		/// </summary>
		PercentSearchRefinements PercentSearchRefinements { get; }
		/// <summary>
		/// 	The session duration where a use of your internal search feature occurred.
		/// </summary>
		SearchDuration SearchDuration { get; }
		/// <summary>
		/// 	The average time (in seconds) users spent on your property after searching.
		/// </summary>
		AvgSearchDuration AvgSearchDuration { get; }
		/// <summary>
		/// 	The number of exits on your site that occurred following a search result from your internal search feature.
		/// </summary>
		SearchExits SearchExits { get; }
		/// <summary>
		/// 	The percentage of searches that resulted in an immediate exit from your property.
		/// </summary>
		SearchExitRate SearchExitRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal1ConversionRate SearchGoal1ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal2ConversionRate SearchGoal2ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal3ConversionRate SearchGoal3ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal4ConversionRate SearchGoal4ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal5ConversionRate SearchGoal5ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal6ConversionRate SearchGoal6ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal7ConversionRate SearchGoal7ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal8ConversionRate SearchGoal8ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal9ConversionRate SearchGoal9ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal10ConversionRate SearchGoal10ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal11ConversionRate SearchGoal11ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal12ConversionRate SearchGoal12ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal13ConversionRate SearchGoal13ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal14ConversionRate SearchGoal14ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal15ConversionRate SearchGoal15ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal16ConversionRate SearchGoal16ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal17ConversionRate SearchGoal17ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal18ConversionRate SearchGoal18ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal19ConversionRate SearchGoal19ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
		/// </summary>
		SearchGoal20ConversionRate SearchGoal20ConversionRate { get; }
		/// <summary>
		/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to at least one of your goals.
		/// </summary>
		SearchGoalConversionRateAll SearchGoalConversionRateAll { get; }
		/// <summary>
		/// 	The average goal value of a search.
		/// </summary>
		GoalValueAllPerSearch GoalValueAllPerSearch { get; }
		/// <summary>
		/// 	Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
		/// </summary>
		PageLoadTime PageLoadTime { get; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the average page load time.
		/// </summary>
		PageLoadSample PageLoadSample { get; }
		/// <summary>
		/// 	The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
		/// </summary>
		AvgPageLoadTime AvgPageLoadTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.
		/// </summary>
		DomainLookupTime DomainLookupTime { get; }
		/// <summary>
		/// 	The average amount of time (in seconds) spent in DNS lookup for this page.
		/// </summary>
		AvgDomainLookupTime AvgDomainLookupTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) to download this page among all samples.
		/// </summary>
		PageDownloadTime PageDownloadTime { get; }
		/// <summary>
		/// 	The average amount of time (in seconds) to download this page.
		/// </summary>
		AvgPageDownloadTime AvgPageDownloadTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.
		/// </summary>
		RedirectionTime RedirectionTime { get; }
		/// <summary>
		/// 	The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0.
		/// </summary>
		AvgRedirectionTime AvgRedirectionTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.
		/// </summary>
		ServerConnectionTime ServerConnectionTime { get; }
		/// <summary>
		/// 	The average amount of time (in seconds) spent in establishing TCP connection for this page.
		/// </summary>
		AvgServerConnectionTime AvgServerConnectionTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.
		/// </summary>
		ServerResponseTime ServerResponseTime { get; }
		/// <summary>
		/// 	The average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server.
		/// </summary>
		AvgServerResponseTime AvgServerResponseTime { get; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
		/// </summary>
		SpeedMetricsSample SpeedMetricsSample { get; }
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.
		/// </summary>
		DomInteractiveTime DomInteractiveTime { get; }
		/// <summary>
		/// 	The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server.
		/// </summary>
		AvgDomInteractiveTime AvgDomInteractiveTime { get; }
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.
		/// </summary>
		DomContentLoadedTime DomContentLoadedTime { get; }
		/// <summary>
		/// 	The average time (in seconds) it takes the browser to parse the document.
		/// </summary>
		AvgDomContentLoadedTime AvgDomContentLoadedTime { get; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.
		/// </summary>
		DomLatencyMetricsSample DomLatencyMetricsSample { get; }
		/// <summary>
		/// 	The total number of screenviews.
		/// </summary>
		Screenviews Screenviews { get; }
		/// <summary>
		/// 	The number of unique screen views. Screen views in different sessions count a separate screen views.
		/// </summary>
		UniqueScreenviews UniqueScreenviews { get; }
		/// <summary>
		/// 	The average number of screenviews per session.
		/// </summary>
		ScreenviewsPerSession ScreenviewsPerSession { get; }
		/// <summary>
		/// 	The time spent viewing the current screen.
		/// </summary>
		TimeOnScreen TimeOnScreen { get; }
		/// <summary>
		/// 	The average amount of time users spent on a screen in seconds.
		/// </summary>
		AvgScreenviewDuration AvgScreenviewDuration { get; }
		/// <summary>
		/// 	The total number of events for the profile, across all categories.
		/// </summary>
		TotalEvents TotalEvents { get; }
		/// <summary>
		/// 	The number of unique events. Events in different sessions count as separate events.
		/// </summary>
		UniqueEvents UniqueEvents { get; }
		/// <summary>
		/// 	The total value of events for the profile.
		/// </summary>
		EventValue EventValue { get; }
		/// <summary>
		/// 	The average value of an event.
		/// </summary>
		AvgEventValue AvgEventValue { get; }
		/// <summary>
		/// 	The total number of sessions with events.
		/// </summary>
		SessionsWithEvent SessionsWithEvent { get; }
		/// <summary>
		/// 	The average number of events per session with event.
		/// </summary>
		EventsPerSessionWithEvent EventsPerSessionWithEvent { get; }
		/// <summary>
		/// 	The total number of transactions.
		/// </summary>
		Transactions Transactions { get; }
		/// <summary>
		/// 	The average number of transactions for a session.
		/// </summary>
		TransactionsPerSession TransactionsPerSession { get; }
		/// <summary>
		/// 	The total sale revenue provided in the transaction excluding shipping and tax.
		/// </summary>
		TransactionRevenue TransactionRevenue { get; }
		/// <summary>
		/// 	The average revenue for an e-commerce transaction.
		/// </summary>
		RevenuePerTransaction RevenuePerTransaction { get; }
		/// <summary>
		/// 	Average transaction revenue for a session.
		/// </summary>
		TransactionRevenuePerSession TransactionRevenuePerSession { get; }
		/// <summary>
		/// 	The total cost of shipping.
		/// </summary>
		TransactionShipping TransactionShipping { get; }
		/// <summary>
		/// 	The total amount of tax.
		/// </summary>
		TransactionTax TransactionTax { get; }
		/// <summary>
		/// 	Total value for your property (including total revenue and total goal value).
		/// </summary>
		TotalValue TotalValue { get; }
		/// <summary>
		/// 	The total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased.
		/// </summary>
		ItemQuantity ItemQuantity { get; }
		/// <summary>
		/// 	The number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased.
		/// </summary>
		UniquePurchases UniquePurchases { get; }
		/// <summary>
		/// 	The average revenue per item.
		/// </summary>
		RevenuePerItem RevenuePerItem { get; }
		/// <summary>
		/// 	The total revenue from purchased product items.
		/// </summary>
		ItemRevenue ItemRevenue { get; }
		/// <summary>
		/// 	The average quantity of this item (or group of items) sold per purchase.
		/// </summary>
		ItemsPerPurchase ItemsPerPurchase { get; }
		/// <summary>
		/// 	Transaction revenue in local currency.
		/// </summary>
		LocalTransactionRevenue LocalTransactionRevenue { get; }
		/// <summary>
		/// 	Transaction shipping cost in local currency.
		/// </summary>
		LocalTransactionShipping LocalTransactionShipping { get; }
		/// <summary>
		/// 	Transaction tax in local currency.
		/// </summary>
		LocalTransactionTax LocalTransactionTax { get; }
		/// <summary>
		/// 	Product revenue in local currency.
		/// </summary>
		LocalItemRevenue LocalItemRevenue { get; }
		/// <summary>
		/// 	The total number of social interactions.
		/// </summary>
		SocialInteractions SocialInteractions { get; }
		/// <summary>
		/// 	The number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget.
		/// </summary>
		UniqueSocialInteractions UniqueSocialInteractions { get; }
		/// <summary>
		/// 	The number of social interactions per session.
		/// </summary>
		SocialInteractionsPerSession SocialInteractionsPerSession { get; }
		/// <summary>
		/// 	The total number of milliseconds for a user timing.
		/// </summary>
		UserTimingValue UserTimingValue { get; }
		/// <summary>
		/// 	The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.
		/// </summary>
		UserTimingSample UserTimingSample { get; }
		/// <summary>
		/// 	The average amount of elapsed time.
		/// </summary>
		AvgUserTimingValue AvgUserTimingValue { get; }
		/// <summary>
		/// 	The number of exceptions that were sent to Google Analytics.
		/// </summary>
		Exceptions Exceptions { get; }
		/// <summary>
		/// 	The number of exceptions thrown divided by the number of screenviews.
		/// </summary>
		ExceptionsPerScreenview ExceptionsPerScreenview { get; }
		/// <summary>
		/// 	The number of exceptions where isFatal is set to true.
		/// </summary>
		FatalExceptions FatalExceptions { get; }
		/// <summary>
		/// 	The number of fatal exceptions thrown divided by the number of screenviews.
		/// </summary>
		FatalExceptionsPerScreenview FatalExceptionsPerScreenview { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 1 refers the number/index of the custom metric. Note that the data type of ga:metric1 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric1 Metric1 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 2 refers the number/index of the custom metric. Note that the data type of ga:metric2 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric2 Metric2 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 3 refers the number/index of the custom metric. Note that the data type of ga:metric3 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric3 Metric3 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 4 refers the number/index of the custom metric. Note that the data type of ga:metric4 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric4 Metric4 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 5 refers the number/index of the custom metric. Note that the data type of ga:metric5 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric5 Metric5 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 6 refers the number/index of the custom metric. Note that the data type of ga:metric6 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric6 Metric6 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 7 refers the number/index of the custom metric. Note that the data type of ga:metric7 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric7 Metric7 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 8 refers the number/index of the custom metric. Note that the data type of ga:metric8 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric8 Metric8 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 9 refers the number/index of the custom metric. Note that the data type of ga:metric9 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric9 Metric9 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 10 refers the number/index of the custom metric. Note that the data type of ga:metric10 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric10 Metric10 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 11 refers the number/index of the custom metric. Note that the data type of ga:metric11 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric11 Metric11 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 12 refers the number/index of the custom metric. Note that the data type of ga:metric12 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric12 Metric12 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 13 refers the number/index of the custom metric. Note that the data type of ga:metric13 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric13 Metric13 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 14 refers the number/index of the custom metric. Note that the data type of ga:metric14 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric14 Metric14 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 15 refers the number/index of the custom metric. Note that the data type of ga:metric15 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric15 Metric15 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 16 refers the number/index of the custom metric. Note that the data type of ga:metric16 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric16 Metric16 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 17 refers the number/index of the custom metric. Note that the data type of ga:metric17 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric17 Metric17 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 18 refers the number/index of the custom metric. Note that the data type of ga:metric18 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric18 Metric18 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 19 refers the number/index of the custom metric. Note that the data type of ga:metric19 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric19 Metric19 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 20 refers the number/index of the custom metric. Note that the data type of ga:metric20 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric20 Metric20 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 21 refers the number/index of the custom metric. Note that the data type of ga:metric21 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric21 Metric21 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 22 refers the number/index of the custom metric. Note that the data type of ga:metric22 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric22 Metric22 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 23 refers the number/index of the custom metric. Note that the data type of ga:metric23 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric23 Metric23 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 24 refers the number/index of the custom metric. Note that the data type of ga:metric24 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric24 Metric24 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 25 refers the number/index of the custom metric. Note that the data type of ga:metric25 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric25 Metric25 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 26 refers the number/index of the custom metric. Note that the data type of ga:metric26 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric26 Metric26 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 27 refers the number/index of the custom metric. Note that the data type of ga:metric27 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric27 Metric27 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 28 refers the number/index of the custom metric. Note that the data type of ga:metric28 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric28 Metric28 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 29 refers the number/index of the custom metric. Note that the data type of ga:metric29 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric29 Metric29 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 30 refers the number/index of the custom metric. Note that the data type of ga:metric30 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric30 Metric30 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 31 refers the number/index of the custom metric. Note that the data type of ga:metric31 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric31 Metric31 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 32 refers the number/index of the custom metric. Note that the data type of ga:metric32 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric32 Metric32 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 33 refers the number/index of the custom metric. Note that the data type of ga:metric33 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric33 Metric33 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 34 refers the number/index of the custom metric. Note that the data type of ga:metric34 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric34 Metric34 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 35 refers the number/index of the custom metric. Note that the data type of ga:metric35 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric35 Metric35 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 36 refers the number/index of the custom metric. Note that the data type of ga:metric36 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric36 Metric36 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 37 refers the number/index of the custom metric. Note that the data type of ga:metric37 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric37 Metric37 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 38 refers the number/index of the custom metric. Note that the data type of ga:metric38 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric38 Metric38 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 39 refers the number/index of the custom metric. Note that the data type of ga:metric39 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric39 Metric39 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 40 refers the number/index of the custom metric. Note that the data type of ga:metric40 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric40 Metric40 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 41 refers the number/index of the custom metric. Note that the data type of ga:metric41 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric41 Metric41 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 42 refers the number/index of the custom metric. Note that the data type of ga:metric42 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric42 Metric42 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 43 refers the number/index of the custom metric. Note that the data type of ga:metric43 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric43 Metric43 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 44 refers the number/index of the custom metric. Note that the data type of ga:metric44 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric44 Metric44 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 45 refers the number/index of the custom metric. Note that the data type of ga:metric45 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric45 Metric45 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 46 refers the number/index of the custom metric. Note that the data type of ga:metric46 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric46 Metric46 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 47 refers the number/index of the custom metric. Note that the data type of ga:metric47 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric47 Metric47 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 48 refers the number/index of the custom metric. Note that the data type of ga:metric48 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric48 Metric48 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 49 refers the number/index of the custom metric. Note that the data type of ga:metric49 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric49 Metric49 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 50 refers the number/index of the custom metric. Note that the data type of ga:metric50 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric50 Metric50 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 51 refers the number/index of the custom metric. Note that the data type of ga:metric51 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric51 Metric51 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 52 refers the number/index of the custom metric. Note that the data type of ga:metric52 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric52 Metric52 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 53 refers the number/index of the custom metric. Note that the data type of ga:metric53 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric53 Metric53 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 54 refers the number/index of the custom metric. Note that the data type of ga:metric54 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric54 Metric54 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 55 refers the number/index of the custom metric. Note that the data type of ga:metric55 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric55 Metric55 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 56 refers the number/index of the custom metric. Note that the data type of ga:metric56 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric56 Metric56 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 57 refers the number/index of the custom metric. Note that the data type of ga:metric57 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric57 Metric57 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 58 refers the number/index of the custom metric. Note that the data type of ga:metric58 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric58 Metric58 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 59 refers the number/index of the custom metric. Note that the data type of ga:metric59 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric59 Metric59 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 60 refers the number/index of the custom metric. Note that the data type of ga:metric60 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric60 Metric60 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 61 refers the number/index of the custom metric. Note that the data type of ga:metric61 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric61 Metric61 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 62 refers the number/index of the custom metric. Note that the data type of ga:metric62 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric62 Metric62 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 63 refers the number/index of the custom metric. Note that the data type of ga:metric63 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric63 Metric63 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 64 refers the number/index of the custom metric. Note that the data type of ga:metric64 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric64 Metric64 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 65 refers the number/index of the custom metric. Note that the data type of ga:metric65 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric65 Metric65 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 66 refers the number/index of the custom metric. Note that the data type of ga:metric66 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric66 Metric66 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 67 refers the number/index of the custom metric. Note that the data type of ga:metric67 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric67 Metric67 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 68 refers the number/index of the custom metric. Note that the data type of ga:metric68 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric68 Metric68 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 69 refers the number/index of the custom metric. Note that the data type of ga:metric69 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric69 Metric69 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 70 refers the number/index of the custom metric. Note that the data type of ga:metric70 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric70 Metric70 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 71 refers the number/index of the custom metric. Note that the data type of ga:metric71 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric71 Metric71 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 72 refers the number/index of the custom metric. Note that the data type of ga:metric72 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric72 Metric72 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 73 refers the number/index of the custom metric. Note that the data type of ga:metric73 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric73 Metric73 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 74 refers the number/index of the custom metric. Note that the data type of ga:metric74 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric74 Metric74 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 75 refers the number/index of the custom metric. Note that the data type of ga:metric75 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric75 Metric75 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 76 refers the number/index of the custom metric. Note that the data type of ga:metric76 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric76 Metric76 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 77 refers the number/index of the custom metric. Note that the data type of ga:metric77 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric77 Metric77 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 78 refers the number/index of the custom metric. Note that the data type of ga:metric78 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric78 Metric78 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 79 refers the number/index of the custom metric. Note that the data type of ga:metric79 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric79 Metric79 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 80 refers the number/index of the custom metric. Note that the data type of ga:metric80 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric80 Metric80 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 81 refers the number/index of the custom metric. Note that the data type of ga:metric81 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric81 Metric81 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 82 refers the number/index of the custom metric. Note that the data type of ga:metric82 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric82 Metric82 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 83 refers the number/index of the custom metric. Note that the data type of ga:metric83 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric83 Metric83 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 84 refers the number/index of the custom metric. Note that the data type of ga:metric84 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric84 Metric84 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 85 refers the number/index of the custom metric. Note that the data type of ga:metric85 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric85 Metric85 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 86 refers the number/index of the custom metric. Note that the data type of ga:metric86 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric86 Metric86 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 87 refers the number/index of the custom metric. Note that the data type of ga:metric87 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric87 Metric87 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 88 refers the number/index of the custom metric. Note that the data type of ga:metric88 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric88 Metric88 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 89 refers the number/index of the custom metric. Note that the data type of ga:metric89 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric89 Metric89 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 90 refers the number/index of the custom metric. Note that the data type of ga:metric90 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric90 Metric90 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 91 refers the number/index of the custom metric. Note that the data type of ga:metric91 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric91 Metric91 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 92 refers the number/index of the custom metric. Note that the data type of ga:metric92 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric92 Metric92 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 93 refers the number/index of the custom metric. Note that the data type of ga:metric93 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric93 Metric93 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 94 refers the number/index of the custom metric. Note that the data type of ga:metric94 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric94 Metric94 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 95 refers the number/index of the custom metric. Note that the data type of ga:metric95 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric95 Metric95 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 96 refers the number/index of the custom metric. Note that the data type of ga:metric96 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric96 Metric96 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 97 refers the number/index of the custom metric. Note that the data type of ga:metric97 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric97 Metric97 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 98 refers the number/index of the custom metric. Note that the data type of ga:metric98 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric98 Metric98 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 99 refers the number/index of the custom metric. Note that the data type of ga:metric99 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric99 Metric99 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 100 refers the number/index of the custom metric. Note that the data type of ga:metric100 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric100 Metric100 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 101 refers the number/index of the custom metric. Note that the data type of ga:metric101 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric101 Metric101 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 102 refers the number/index of the custom metric. Note that the data type of ga:metric102 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric102 Metric102 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 103 refers the number/index of the custom metric. Note that the data type of ga:metric103 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric103 Metric103 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 104 refers the number/index of the custom metric. Note that the data type of ga:metric104 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric104 Metric104 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 105 refers the number/index of the custom metric. Note that the data type of ga:metric105 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric105 Metric105 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 106 refers the number/index of the custom metric. Note that the data type of ga:metric106 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric106 Metric106 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 107 refers the number/index of the custom metric. Note that the data type of ga:metric107 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric107 Metric107 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 108 refers the number/index of the custom metric. Note that the data type of ga:metric108 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric108 Metric108 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 109 refers the number/index of the custom metric. Note that the data type of ga:metric109 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric109 Metric109 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 110 refers the number/index of the custom metric. Note that the data type of ga:metric110 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric110 Metric110 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 111 refers the number/index of the custom metric. Note that the data type of ga:metric111 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric111 Metric111 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 112 refers the number/index of the custom metric. Note that the data type of ga:metric112 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric112 Metric112 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 113 refers the number/index of the custom metric. Note that the data type of ga:metric113 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric113 Metric113 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 114 refers the number/index of the custom metric. Note that the data type of ga:metric114 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric114 Metric114 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 115 refers the number/index of the custom metric. Note that the data type of ga:metric115 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric115 Metric115 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 116 refers the number/index of the custom metric. Note that the data type of ga:metric116 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric116 Metric116 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 117 refers the number/index of the custom metric. Note that the data type of ga:metric117 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric117 Metric117 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 118 refers the number/index of the custom metric. Note that the data type of ga:metric118 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric118 Metric118 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 119 refers the number/index of the custom metric. Note that the data type of ga:metric119 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric119 Metric119 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 120 refers the number/index of the custom metric. Note that the data type of ga:metric120 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric120 Metric120 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 121 refers the number/index of the custom metric. Note that the data type of ga:metric121 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric121 Metric121 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 122 refers the number/index of the custom metric. Note that the data type of ga:metric122 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric122 Metric122 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 123 refers the number/index of the custom metric. Note that the data type of ga:metric123 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric123 Metric123 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 124 refers the number/index of the custom metric. Note that the data type of ga:metric124 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric124 Metric124 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 125 refers the number/index of the custom metric. Note that the data type of ga:metric125 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric125 Metric125 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 126 refers the number/index of the custom metric. Note that the data type of ga:metric126 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric126 Metric126 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 127 refers the number/index of the custom metric. Note that the data type of ga:metric127 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric127 Metric127 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 128 refers the number/index of the custom metric. Note that the data type of ga:metric128 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric128 Metric128 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 129 refers the number/index of the custom metric. Note that the data type of ga:metric129 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric129 Metric129 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 130 refers the number/index of the custom metric. Note that the data type of ga:metric130 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric130 Metric130 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 131 refers the number/index of the custom metric. Note that the data type of ga:metric131 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric131 Metric131 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 132 refers the number/index of the custom metric. Note that the data type of ga:metric132 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric132 Metric132 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 133 refers the number/index of the custom metric. Note that the data type of ga:metric133 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric133 Metric133 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 134 refers the number/index of the custom metric. Note that the data type of ga:metric134 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric134 Metric134 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 135 refers the number/index of the custom metric. Note that the data type of ga:metric135 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric135 Metric135 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 136 refers the number/index of the custom metric. Note that the data type of ga:metric136 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric136 Metric136 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 137 refers the number/index of the custom metric. Note that the data type of ga:metric137 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric137 Metric137 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 138 refers the number/index of the custom metric. Note that the data type of ga:metric138 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric138 Metric138 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 139 refers the number/index of the custom metric. Note that the data type of ga:metric139 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric139 Metric139 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 140 refers the number/index of the custom metric. Note that the data type of ga:metric140 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric140 Metric140 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 141 refers the number/index of the custom metric. Note that the data type of ga:metric141 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric141 Metric141 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 142 refers the number/index of the custom metric. Note that the data type of ga:metric142 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric142 Metric142 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 143 refers the number/index of the custom metric. Note that the data type of ga:metric143 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric143 Metric143 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 144 refers the number/index of the custom metric. Note that the data type of ga:metric144 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric144 Metric144 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 145 refers the number/index of the custom metric. Note that the data type of ga:metric145 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric145 Metric145 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 146 refers the number/index of the custom metric. Note that the data type of ga:metric146 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric146 Metric146 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 147 refers the number/index of the custom metric. Note that the data type of ga:metric147 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric147 Metric147 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 148 refers the number/index of the custom metric. Note that the data type of ga:metric148 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric148 Metric148 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 149 refers the number/index of the custom metric. Note that the data type of ga:metric149 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric149 Metric149 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 150 refers the number/index of the custom metric. Note that the data type of ga:metric150 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric150 Metric150 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 151 refers the number/index of the custom metric. Note that the data type of ga:metric151 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric151 Metric151 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 152 refers the number/index of the custom metric. Note that the data type of ga:metric152 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric152 Metric152 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 153 refers the number/index of the custom metric. Note that the data type of ga:metric153 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric153 Metric153 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 154 refers the number/index of the custom metric. Note that the data type of ga:metric154 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric154 Metric154 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 155 refers the number/index of the custom metric. Note that the data type of ga:metric155 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric155 Metric155 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 156 refers the number/index of the custom metric. Note that the data type of ga:metric156 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric156 Metric156 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 157 refers the number/index of the custom metric. Note that the data type of ga:metric157 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric157 Metric157 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 158 refers the number/index of the custom metric. Note that the data type of ga:metric158 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric158 Metric158 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 159 refers the number/index of the custom metric. Note that the data type of ga:metric159 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric159 Metric159 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 160 refers the number/index of the custom metric. Note that the data type of ga:metric160 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric160 Metric160 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 161 refers the number/index of the custom metric. Note that the data type of ga:metric161 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric161 Metric161 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 162 refers the number/index of the custom metric. Note that the data type of ga:metric162 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric162 Metric162 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 163 refers the number/index of the custom metric. Note that the data type of ga:metric163 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric163 Metric163 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 164 refers the number/index of the custom metric. Note that the data type of ga:metric164 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric164 Metric164 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 165 refers the number/index of the custom metric. Note that the data type of ga:metric165 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric165 Metric165 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 166 refers the number/index of the custom metric. Note that the data type of ga:metric166 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric166 Metric166 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 167 refers the number/index of the custom metric. Note that the data type of ga:metric167 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric167 Metric167 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 168 refers the number/index of the custom metric. Note that the data type of ga:metric168 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric168 Metric168 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 169 refers the number/index of the custom metric. Note that the data type of ga:metric169 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric169 Metric169 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 170 refers the number/index of the custom metric. Note that the data type of ga:metric170 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric170 Metric170 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 171 refers the number/index of the custom metric. Note that the data type of ga:metric171 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric171 Metric171 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 172 refers the number/index of the custom metric. Note that the data type of ga:metric172 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric172 Metric172 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 173 refers the number/index of the custom metric. Note that the data type of ga:metric173 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric173 Metric173 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 174 refers the number/index of the custom metric. Note that the data type of ga:metric174 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric174 Metric174 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 175 refers the number/index of the custom metric. Note that the data type of ga:metric175 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric175 Metric175 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 176 refers the number/index of the custom metric. Note that the data type of ga:metric176 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric176 Metric176 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 177 refers the number/index of the custom metric. Note that the data type of ga:metric177 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric177 Metric177 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 178 refers the number/index of the custom metric. Note that the data type of ga:metric178 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric178 Metric178 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 179 refers the number/index of the custom metric. Note that the data type of ga:metric179 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric179 Metric179 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 180 refers the number/index of the custom metric. Note that the data type of ga:metric180 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric180 Metric180 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 181 refers the number/index of the custom metric. Note that the data type of ga:metric181 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric181 Metric181 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 182 refers the number/index of the custom metric. Note that the data type of ga:metric182 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric182 Metric182 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 183 refers the number/index of the custom metric. Note that the data type of ga:metric183 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric183 Metric183 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 184 refers the number/index of the custom metric. Note that the data type of ga:metric184 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric184 Metric184 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 185 refers the number/index of the custom metric. Note that the data type of ga:metric185 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric185 Metric185 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 186 refers the number/index of the custom metric. Note that the data type of ga:metric186 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric186 Metric186 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 187 refers the number/index of the custom metric. Note that the data type of ga:metric187 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric187 Metric187 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 188 refers the number/index of the custom metric. Note that the data type of ga:metric188 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric188 Metric188 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 189 refers the number/index of the custom metric. Note that the data type of ga:metric189 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric189 Metric189 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 190 refers the number/index of the custom metric. Note that the data type of ga:metric190 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric190 Metric190 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 191 refers the number/index of the custom metric. Note that the data type of ga:metric191 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric191 Metric191 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 192 refers the number/index of the custom metric. Note that the data type of ga:metric192 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric192 Metric192 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 193 refers the number/index of the custom metric. Note that the data type of ga:metric193 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric193 Metric193 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 194 refers the number/index of the custom metric. Note that the data type of ga:metric194 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric194 Metric194 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 195 refers the number/index of the custom metric. Note that the data type of ga:metric195 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric195 Metric195 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 196 refers the number/index of the custom metric. Note that the data type of ga:metric196 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric196 Metric196 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 197 refers the number/index of the custom metric. Note that the data type of ga:metric197 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric197 Metric197 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 198 refers the number/index of the custom metric. Note that the data type of ga:metric198 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric198 Metric198 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 199 refers the number/index of the custom metric. Note that the data type of ga:metric199 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric199 Metric199 { get; }
		/// <summary>
		/// 	The name of the requested custom metric, where 200 refers the number/index of the custom metric. Note that the data type of ga:metric200 can be INTEGER, CURRENCY or TIME.
		/// </summary>
		Metric200 Metric200 { get; }
		/// <summary>
		/// 	The number of DCM Floodlight conversions (premium only).
		/// </summary>
		DcmFloodlightQuantity DcmFloodlightQuantity { get; }
		/// <summary>
		/// 	DCM Floodlight revenue (premium only).
		/// </summary>
		DcmFloodlightRevenue DcmFloodlightRevenue { get; }
		/// <summary>
		/// 	The total revenue from AdSense ads.
		/// </summary>
		AdsenseRevenue AdsenseRevenue { get; }
		/// <summary>
		/// 	The number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en
		/// </summary>
		AdsenseAdUnitsViewed AdsenseAdUnitsViewed { get; }
		/// <summary>
		/// 	The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.
		/// </summary>
		AdsenseAdsViewed AdsenseAdsViewed { get; }
		/// <summary>
		/// 	The number of times AdSense ads on your site were clicked.
		/// </summary>
		AdsenseAdsClicks AdsenseAdsClicks { get; }
		/// <summary>
		/// 	The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.
		/// </summary>
		AdsensePageImpressions AdsensePageImpressions { get; }
		/// <summary>
		/// 	The percentage of page impressions that resulted in a click on an AdSense ad.
		/// </summary>
		AdsenseCTR AdsenseCTR { get; }
		/// <summary>
		/// 	The estimated cost per thousand page impressions. It is your AdSense Revenue per 1000 page impressions.
		/// </summary>
		AdsenseECPM AdsenseECPM { get; }
		/// <summary>
		/// 	The number of sessions that ended due to a user clicking on an AdSense ad.
		/// </summary>
		AdsenseExits AdsenseExits { get; }
		/// <summary>
		/// 	The percentage of impressions that were viewable.
		/// </summary>
		AdsenseViewableImpressionPercent AdsenseViewableImpressionPercent { get; }
		/// <summary>
		/// 	The percentage of ad requests that returned at least one ad.
		/// </summary>
		AdsenseCoverage AdsenseCoverage { get; }
		/// <summary>
		/// 	An AdX ad impression is reported whenever an individual ad is displayed on your website. For example, if a page with two ad units is viewed once, we'll display two impressions.
		/// </summary>
		AdxImpressions AdxImpressions { get; }
		/// <summary>
		/// 	Coverage is the percentage of ad requests that returned at least one ad. Generally, coverage can help you identify sites where your AdX account isn't able to provide targeted ads. (Ad Impressions / Total Ad Requests) * 100
		/// </summary>
		AdxCoverage AdxCoverage { get; }
		/// <summary>
		/// 	Monetized Pageviews measures the total number of pageviews on your property that were shown with an ad from your linked AdX account. Note - a single page can have multiple ad units.
		/// </summary>
		AdxMonetizedPageviews AdxMonetizedPageviews { get; }
		/// <summary>
		/// 	The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).
		/// </summary>
		AdxImpressionsPerSession AdxImpressionsPerSession { get; }
		/// <summary>
		/// 	The percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has appeared within a user's browser and had the opportunity to be seen.
		/// </summary>
		AdxViewableImpressionsPercent AdxViewableImpressionsPercent { get; }
		/// <summary>
		/// 	The number of times AdX ads were clicked on your site.
		/// </summary>
		AdxClicks AdxClicks { get; }
		/// <summary>
		/// 	The percentage of pageviews that resulted in a click on an AdX ad.
		/// </summary>
		AdxCTR AdxCTR { get; }
		/// <summary>
		/// 	The total estimated revenue from AdX ads.
		/// </summary>
		AdxRevenue AdxRevenue { get; }
		/// <summary>
		/// 	The total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions.
		/// </summary>
		AdxRevenuePer1000Sessions AdxRevenuePer1000Sessions { get; }
		/// <summary>
		/// 	The effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews.
		/// </summary>
		AdxECPM AdxECPM { get; }
		/// <summary>
		/// 	Unique purchases divided by views of product detail pages (Enhanced Ecommerce).
		/// </summary>
		BuyToDetailRate BuyToDetailRate { get; }
		/// <summary>
		/// 	Product adds divided by views of product details (Enhanced Ecommerce).
		/// </summary>
		CartToDetailRate CartToDetailRate { get; }
		/// <summary>
		/// 	Correlation Score for related products.
		/// </summary>
		CorrelationScore CorrelationScore { get; }
		/// <summary>
		/// 	DCM Cost Per Click (premium only).
		/// </summary>
		DcmCPC DcmCPC { get; }
		/// <summary>
		/// 	DCM Click Through Rate (premium only).
		/// </summary>
		DcmCTR DcmCTR { get; }
		/// <summary>
		/// 	DCM Total Clicks (premium only).
		/// </summary>
		DcmClicks DcmClicks { get; }
		/// <summary>
		/// 	DCM Total Cost (premium only).
		/// </summary>
		DcmCost DcmCost { get; }
		/// <summary>
		/// 	DCM Total Impressions (premium only).
		/// </summary>
		DcmImpressions DcmImpressions { get; }
		/// <summary>
		/// 	DCM Return On Ad Spend (ROAS) (premium only).
		/// </summary>
		DcmROAS DcmROAS { get; }
		/// <summary>
		/// 	DCM Revenue Per Click (premium only).
		/// </summary>
		DcmRPC DcmRPC { get; }
		/// <summary>
		/// 	Total number of hits sent to Google Analytics, for the view (profile). This metric sums all hit types, including pageview, custom event, ecommerce, and other types. Note that this number is based on the view (profile), not the property, and therefore is not the same as the property's hit volume.
		/// </summary>
		Hits Hits { get; }
		/// <summary>
		/// 	The rate at which users clicked through to view the internal promotion (ga:internalPromotionClicks / ga:internalPromotionViews) - (Enhanced Ecommerce).
		/// </summary>
		InternalPromotionCTR InternalPromotionCTR { get; }
		/// <summary>
		/// 	The number of clicks on an internal promotion (Enhanced Ecommerce).
		/// </summary>
		InternalPromotionClicks InternalPromotionClicks { get; }
		/// <summary>
		/// 	The number of views of an internal promotion (Enhanced Ecommerce).
		/// </summary>
		InternalPromotionViews InternalPromotionViews { get; }
		/// <summary>
		/// 	Refund amount for a given product in the local currency (Enhanced Ecommerce).
		/// </summary>
		LocalProductRefundAmount LocalProductRefundAmount { get; }
		/// <summary>
		/// 	Total refund amount for the transaction in the local currency (Enhanced Ecommerce).
		/// </summary>
		LocalRefundAmount LocalRefundAmount { get; }
		/// <summary>
		/// 	Number of times the product was added to the shopping cart (Enhanced Ecommerce).
		/// </summary>
		ProductAddsToCart ProductAddsToCart { get; }
		/// <summary>
		/// 	Number of times the product was included in the check-out process (Enhanced Ecommerce).
		/// </summary>
		ProductCheckouts ProductCheckouts { get; }
		/// <summary>
		/// 	Number of times users viewed the product-detail page (Enhanced Ecommerce).
		/// </summary>
		ProductDetailViews ProductDetailViews { get; }
		/// <summary>
		/// 	The rate at which users clicked through on the product in a product list (ga:productListClicks / ga:productListViews) - (Enhanced Ecommerce).
		/// </summary>
		ProductListCTR ProductListCTR { get; }
		/// <summary>
		/// 	Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).
		/// </summary>
		ProductListClicks ProductListClicks { get; }
		/// <summary>
		/// 	Number of times the product appeared in a product list (Enhanced Ecommerce).
		/// </summary>
		ProductListViews ProductListViews { get; }
		/// <summary>
		/// 	Total refund amount associated with the product (Enhanced Ecommerce).
		/// </summary>
		ProductRefundAmount ProductRefundAmount { get; }
		/// <summary>
		/// 	Number of times a refund was issued for the product (Enhanced Ecommerce).
		/// </summary>
		ProductRefunds ProductRefunds { get; }
		/// <summary>
		/// 	Number of times the product was removed from shopping cart (Enhanced Ecommerce).
		/// </summary>
		ProductRemovesFromCart ProductRemovesFromCart { get; }
		/// <summary>
		/// 	Average product revenue per purchase (commonly used with Product Coupon Code) (ga:itemRevenue / ga:uniquePurchases) - (Enhanced Ecommerce).
		/// </summary>
		ProductRevenuePerPurchase ProductRevenuePerPurchase { get; }
		/// <summary>
		/// 	Number of product units added to the shopping cart (Enhanced Ecommerce).
		/// </summary>
		QuantityAddedToCart QuantityAddedToCart { get; }
		/// <summary>
		/// 	Number of product units included in check out (Enhanced Ecommerce).
		/// </summary>
		QuantityCheckedOut QuantityCheckedOut { get; }
		/// <summary>
		/// 	Number of product units refunded (Enhanced Ecommerce).
		/// </summary>
		QuantityRefunded QuantityRefunded { get; }
		/// <summary>
		/// 	Number of product units removed from cart (Enhanced Ecommerce).
		/// </summary>
		QuantityRemovedFromCart QuantityRemovedFromCart { get; }
		/// <summary>
		/// 	Quantity of the product being queried.
		/// </summary>
		QueryProductQuantity QueryProductQuantity { get; }
		/// <summary>
		/// 	Currency amount refunded for a transaction (Enhanced Ecommerce).
		/// </summary>
		RefundAmount RefundAmount { get; }
		/// <summary>
		/// 	Quantity of the related product.
		/// </summary>
		RelatedProductQuantity RelatedProductQuantity { get; }
		/// <summary>
		/// 	The total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users.
		/// </summary>
		RevenuePerUser RevenuePerUser { get; }
		/// <summary>
		/// 	The total number of sessions divided by the total number of users.
		/// </summary>
		SessionsPerUser SessionsPerUser { get; }
		/// <summary>
		/// 	Number of refunds that have been issued (Enhanced Ecommerce).
		/// </summary>
		TotalRefunds TotalRefunds { get; }
		/// <summary>
		/// 	The total number of transactions divided by the total number of users.
		/// </summary>
		TransactionsPerUser TransactionsPerUser { get; }
		/// <summary>
		/// 	A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.
		/// </summary>
		UserType UserType { get; }
		/// <summary>
		/// 	The session index for a user. Each session from a unique user will get its own incremental index starting from 1 for the first session. Subsequent sessions do not change previous session indicies. For example, if a certain user has 4 sessions to your website, sessionCount for that user will have 4 distinct values of '1' through '4'.
		/// </summary>
		SessionCount SessionCount { get; }
		/// <summary>
		/// 	The number of days elapsed since users last visited your property. Used to calculate user loyalty.
		/// </summary>
		DaysSinceLastSession DaysSinceLastSession { get; }
		/// <summary>
		/// 	The value provided when you define custom user segments for your property.
		/// </summary>
		UserDefinedValue UserDefinedValue { get; }
		/// <summary>
		/// 	The length of a session measured in seconds and reported in second increments. The value returned is a string.
		/// </summary>
		SessionDurationBucket SessionDurationBucket { get; }
		/// <summary>
		/// 	The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link.
		/// </summary>
		ReferralPath ReferralPath { get; }
		/// <summary>
		/// 	The full referring URL including the hostname and path.
		/// </summary>
		FullReferrer FullReferrer { get; }
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_campaign campaign tracking parameter. When using AdWords autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the value (not set) is used.
		/// </summary>
		Campaign Campaign { get; }
		/// <summary>
		/// 	The source of referrals. When using manual campaign tracking, the value of the utm_source campaign tracking parameter. When using AdWords autotagging, the value is google. Otherwise the domain of the source referring the user (e.g. document.referrer). The value may also contain a port address. If the user arrived without a referrer, the value is (direct)
		/// </summary>
		Source Source { get; }
		/// <summary>
		/// 	The type of referrals. When using manual campaign tracking, the value of the utm_medium campaign tracking parameter. When using AdWords autotagging, the value is ppc. If the user comes from a search engine detected by Google Analytics, the value is organic. If the referrer is not a search engine, the value is referral. If the users came directly to the property, and document.referrer is empty, the value is (none).
		/// </summary>
		Medium Medium { get; }
		/// <summary>
		/// 	Combined values of ga:source and ga:medium.
		/// </summary>
		SourceMedium SourceMedium { get; }
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_term campaign tracking parameter. When using AdWords autotagging or if a user used organic search to reach your property, the keywords used by users to reach your property. Otherwise the value is (not set).
		/// </summary>
		Keyword Keyword { get; }
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_content campaign tracking parameter. When using AdWords autotagging, the first line of the text for your online Ad campaign. If you are using mad libs for your AdWords content, this field displays the keywords you provided for the mad libs keyword match. Otherwise the value is (not set)
		/// </summary>
		AdContent AdContent { get; }
		/// <summary>
		/// 	Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc.
		/// </summary>
		SocialNetwork SocialNetwork { get; }
		/// <summary>
		/// 	Indicates sessions that arrived to the property from a social source. The possible values are Yes or No where the first letter is capitalized.
		/// </summary>
		HasSocialSourceReferral HasSocialSourceReferral { get; }
		/// <summary>
		/// 	The name of your AdWords ad group.
		/// </summary>
		AdGroup AdGroup { get; }
		/// <summary>
		/// 	The location of the advertisement on the hosting page (Top, RHS, or not set).
		/// </summary>
		AdSlot AdSlot { get; }
		/// <summary>
		/// 	The networks used to deliver your ads (Content, Search, Search partners, etc.).
		/// </summary>
		AdDistributionNetwork AdDistributionNetwork { get; }
		/// <summary>
		/// 	The match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content network are identified as "Content network". Details: https://support.google.com/adwords/answer/2472708?hl=en
		/// </summary>
		AdMatchType AdMatchType { get; }
		/// <summary>
		/// 	The match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en
		/// </summary>
		AdKeywordMatchType AdKeywordMatchType { get; }
		/// <summary>
		/// 	The search queries that triggered impressions of your AdWords ads.
		/// </summary>
		AdMatchedQuery AdMatchedQuery { get; }
		/// <summary>
		/// 	The domains where your ads on the content network were placed.
		/// </summary>
		AdPlacementDomain AdPlacementDomain { get; }
		/// <summary>
		/// 	The URLs where your ads on the content network were placed.
		/// </summary>
		AdPlacementUrl AdPlacementUrl { get; }
		/// <summary>
		/// 	Your AdWords ad formats (Text, Image, Flash, Video, etc.).
		/// </summary>
		AdFormat AdFormat { get; }
		/// <summary>
		/// 	How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).
		/// </summary>
		AdTargetingType AdTargetingType { get; }
		/// <summary>
		/// 	How you manage your ads on the content network. Values are Automatic placements or Managed placements.
		/// </summary>
		AdTargetingOption AdTargetingOption { get; }
		/// <summary>
		/// 	The URLs your AdWords ads displayed.
		/// </summary>
		AdDisplayUrl AdDisplayUrl { get; }
		/// <summary>
		/// 	The URLs to which your AdWords ads referred traffic.
		/// </summary>
		AdDestinationUrl AdDestinationUrl { get; }
		/// <summary>
		/// 	A string. Corresponds to AdWords API AccountInfo.customerId.
		/// </summary>
		AdwordsCustomerId AdwordsCustomerId { get; }
		/// <summary>
		/// 	A string. Corresponds to AdWords API Campaign.id.
		/// </summary>
		AdwordsCampaignId AdwordsCampaignId { get; }
		/// <summary>
		/// 	A string. Corresponds to AdWords API AdGroup.id.
		/// </summary>
		AdwordsAdGroupId AdwordsAdGroupId { get; }
		/// <summary>
		/// 	A string. Corresponds to AdWords API Ad.id.
		/// </summary>
		AdwordsCreativeId AdwordsCreativeId { get; }
		/// <summary>
		/// 	A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
		/// </summary>
		AdwordsCriteriaId AdwordsCriteriaId { get; }
		/// <summary>
		/// 	The number of words in the search query.
		/// </summary>
		AdQueryWordCount AdQueryWordCount { get; }
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal completion.
		/// </summary>
		GoalCompletionLocation GoalCompletionLocation { get; }
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal, one step prior to the goal completion location.
		/// </summary>
		GoalPreviousStep1 GoalPreviousStep1 { get; }
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal, two steps prior to the goal completion location.
		/// </summary>
		GoalPreviousStep2 GoalPreviousStep2 { get; }
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal, three steps prior to the goal completion location.
		/// </summary>
		GoalPreviousStep3 GoalPreviousStep3 { get; }
		/// <summary>
		/// 	The names of browsers used by users to your website. For example, Internet Explorer or Firefox.
		/// </summary>
		Browser Browser { get; }
		/// <summary>
		/// 	The browser versions used by users to your website. For example, 2.0.0.14
		/// </summary>
		BrowserVersion BrowserVersion { get; }
		/// <summary>
		/// 	The operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod.
		/// </summary>
		OperatingSystem OperatingSystem { get; }
		/// <summary>
		/// 	The version of the operating system used by your users, such as XP for Windows or PPC for Macintosh.
		/// </summary>
		OperatingSystemVersion OperatingSystemVersion { get; }
		/// <summary>
		/// 	Mobile manufacturer or branded name.
		/// </summary>
		MobileDeviceBranding MobileDeviceBranding { get; }
		/// <summary>
		/// 	Mobile device model.
		/// </summary>
		MobileDeviceModel MobileDeviceModel { get; }
		/// <summary>
		/// 	Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).
		/// </summary>
		MobileInputSelector MobileInputSelector { get; }
		/// <summary>
		/// 	The branding, model, and marketing name used to identify the mobile device.
		/// </summary>
		MobileDeviceInfo MobileDeviceInfo { get; }
		/// <summary>
		/// 	The marketing name used for the mobile device.
		/// </summary>
		MobileDeviceMarketingName MobileDeviceMarketingName { get; }
		/// <summary>
		/// 	The type of device: desktop, tablet, or mobile.
		/// </summary>
		DeviceCategory DeviceCategory { get; }
		/// <summary>
		/// 	The continents of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		Continent Continent { get; }
		/// <summary>
		/// 	The sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe.
		/// </summary>
		SubContinent SubContinent { get; }
		/// <summary>
		/// 	The country of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		Country Country { get; }
		/// <summary>
		/// 	The region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York.
		/// </summary>
		Region Region { get; }
		/// <summary>
		/// 	The Designated Market Area (DMA) from where traffic arrived.
		/// </summary>
		Metro Metro { get; }
		/// <summary>
		/// 	The cities of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		City City { get; }
		/// <summary>
		/// 	The approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values.
		/// </summary>
		Latitude Latitude { get; }
		/// <summary>
		/// 	The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.
		/// </summary>
		Longitude Longitude { get; }
		/// <summary>
		/// 	The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.
		/// </summary>
		NetworkDomain NetworkDomain { get; }
		/// <summary>
		/// 	The name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element.
		/// </summary>
		NetworkLocation NetworkLocation { get; }
		/// <summary>
		/// 	The versions of Flash supported by users' browsers, including minor versions.
		/// </summary>
		FlashVersion FlashVersion { get; }
		/// <summary>
		/// 	Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.
		/// </summary>
		JavaEnabled JavaEnabled { get; }
		/// <summary>
		/// 	The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).
		/// </summary>
		Language Language { get; }
		/// <summary>
		/// 	The color depth of users' monitors, as retrieved from the DOM of the user's browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit.
		/// </summary>
		ScreenColors ScreenColors { get; }
		/// <summary>
		/// 	Source property display name of roll-up properties. This is valid only for roll-up properties.
		/// </summary>
		SourcePropertyDisplayName SourcePropertyDisplayName { get; }
		/// <summary>
		/// 	Source property tracking ID of roll-up properties. This is valid only for roll-up properties.
		/// </summary>
		SourcePropertyTrackingId SourcePropertyTrackingId { get; }
		/// <summary>
		/// 	The screen resolution of users' screens. For example: 1024x738.
		/// </summary>
		ScreenResolution ScreenResolution { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.)
		/// </summary>
		SocialActivityEndorsingUrl SocialActivityEndorsingUrl { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the title of the social activity posted by the social network user.
		/// </summary>
		SocialActivityDisplayName SocialActivityDisplayName { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the content of the social activity posted by the social network user (e.g. The message content of a Google+ post)
		/// </summary>
		SocialActivityPost SocialActivityPost { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents when the social activity occurred on the social network.
		/// </summary>
		SocialActivityTimestamp SocialActivityTimestamp { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity.
		/// </summary>
		SocialActivityUserHandle SocialActivityUserHandle { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL of the photo associated with the user's social network profile.
		/// </summary>
		SocialActivityUserPhotoUrl SocialActivityUserPhotoUrl { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL of the associated user's social network profile.
		/// </summary>
		SocialActivityUserProfileUrl SocialActivityUserProfileUrl { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL shared by the associated social network user.
		/// </summary>
		SocialActivityContentUrl SocialActivityContentUrl { get; }
		/// <summary>
		/// 	For a social data hub activity, this is a comma-separated set of tags associated with the social activity.
		/// </summary>
		SocialActivityTagsSummary SocialActivityTagsSummary { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the type of social action associated with the activity (e.g. vote, comment, +1, etc.).
		/// </summary>
		SocialActivityAction SocialActivityAction { get; }
		/// <summary>
		/// 	For a social data hub activity, this value represents the type of social action and the social network where the activity originated.
		/// </summary>
		SocialActivityNetworkAction SocialActivityNetworkAction { get; }
		/// <summary>
		/// 	The hostname from which the tracking request was made.
		/// </summary>
		Hostname Hostname { get; }
		/// <summary>
		/// 	A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.
		/// </summary>
		PagePath PagePath { get; }
		/// <summary>
		/// 	This dimension rolls up all the page paths in the first hierarchical level in pagePath.
		/// </summary>
		PagePathLevel1 PagePathLevel1 { get; }
		/// <summary>
		/// 	This dimension rolls up all the page paths in the second hierarchical level in pagePath.
		/// </summary>
		PagePathLevel2 PagePathLevel2 { get; }
		/// <summary>
		/// 	This dimension rolls up all the page paths in the third hierarchical level in pagePath.
		/// </summary>
		PagePathLevel3 PagePathLevel3 { get; }
		/// <summary>
		/// 	This dimension rolls up all the page paths into hierarchical levels. Up to 4 pagePath levels maybe specified. All additional levels in the pagePath hierarchy are also rolled up in this dimension.
		/// </summary>
		PagePathLevel4 PagePathLevel4 { get; }
		/// <summary>
		/// 	The title of a page. Keep in mind that multiple pages might have the same page title.
		/// </summary>
		PageTitle PageTitle { get; }
		/// <summary>
		/// 	The first page in a user's session, or landing page.
		/// </summary>
		LandingPagePath LandingPagePath { get; }
		/// <summary>
		/// 	The second page in a user's session.
		/// </summary>
		SecondPagePath SecondPagePath { get; }
		/// <summary>
		/// 	The last page in a user's session, or exit page.
		/// </summary>
		ExitPagePath ExitPagePath { get; }
		/// <summary>
		/// 	A page that was visited before another page on the same property. Typically used with the pagePath dimension.
		/// </summary>
		PreviousPagePath PreviousPagePath { get; }
		/// <summary>
		/// 	The number of pages visited by users during a session. The value is a histogram that counts pageviews across a range of possible values. In this calculation, all sessions will have at least one pageview, and some percentage of sessions will have more.
		/// </summary>
		PageDepth PageDepth { get; }
		/// <summary>
		/// 	A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.
		/// </summary>
		SearchUsed SearchUsed { get; }
		/// <summary>
		/// 	Search terms used by users within your property.
		/// </summary>
		SearchKeyword SearchKeyword { get; }
		/// <summary>
		/// 	Subsequent keyword search terms or strings entered by users after a given initial string search.
		/// </summary>
		SearchKeywordRefinement SearchKeywordRefinement { get; }
		/// <summary>
		/// 	The categories used for the internal search if you have this enabled for your profile. For example, you might have product categories such as electronics, furniture, or clothing.
		/// </summary>
		SearchCategory SearchCategory { get; }
		/// <summary>
		/// 	A page where the user initiated an internal search.
		/// </summary>
		SearchStartPage SearchStartPage { get; }
		/// <summary>
		/// 	The page the user immediately visited after performing an internal search on your site. (Usually the search results page).
		/// </summary>
		SearchDestinationPage SearchDestinationPage { get; }
		/// <summary>
		/// 	A page that the user visited after performing an internal search on your site.
		/// </summary>
		SearchAfterDestinationPage SearchAfterDestinationPage { get; }
		/// <summary>
		/// 	ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.
		/// </summary>
		AppInstallerId AppInstallerId { get; }
		/// <summary>
		/// 	The version of the application.
		/// </summary>
		AppVersion AppVersion { get; }
		/// <summary>
		/// 	The name of the application.
		/// </summary>
		AppName AppName { get; }
		/// <summary>
		/// 	The ID of the application.
		/// </summary>
		AppId AppId { get; }
		/// <summary>
		/// 	The name of the screen.
		/// </summary>
		ScreenName ScreenName { get; }
		/// <summary>
		/// 	The number of screenviews per session reported as a string. Can be useful for historgrams.
		/// </summary>
		ScreenDepth ScreenDepth { get; }
		/// <summary>
		/// 	The name of the first screen viewed.
		/// </summary>
		LandingScreenName LandingScreenName { get; }
		/// <summary>
		/// 	The name of the screen when the user exited the application.
		/// </summary>
		ExitScreenName ExitScreenName { get; }
		/// <summary>
		/// 	The category of the event.
		/// </summary>
		EventCategory EventCategory { get; }
		/// <summary>
		/// 	The action of the event.
		/// </summary>
		EventAction EventAction { get; }
		/// <summary>
		/// 	The label of the event.
		/// </summary>
		EventLabel EventLabel { get; }
		/// <summary>
		/// 	The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.
		/// </summary>
		TransactionId TransactionId { get; }
		/// <summary>
		/// 	Typically used to designate a supplying company or brick and mortar location; product affiliation.
		/// </summary>
		Affiliation Affiliation { get; }
		/// <summary>
		/// 	The number of sessions between users' purchases and the related campaigns that lead to the purchases.
		/// </summary>
		SessionsToTransaction SessionsToTransaction { get; }
		/// <summary>
		/// 	The number of days between users' purchases and the related campaigns that lead to the purchases.
		/// </summary>
		DaysToTransaction DaysToTransaction { get; }
		/// <summary>
		/// 	The product sku for purchased items as you have defined them in your ecommerce tracking application.
		/// </summary>
		ProductSku ProductSku { get; }
		/// <summary>
		/// 	The product name for purchased items as supplied by your ecommerce tracking application.
		/// </summary>
		ProductName ProductName { get; }
		/// <summary>
		/// 	Any product variations (size, color) for purchased items as supplied by your ecommerce application. Not compatible with Enhanced Ecommerce.
		/// </summary>
		ProductCategory ProductCategory { get; }
		/// <summary>
		/// 	The local currency code of the transaction based on ISO 4217 standard.
		/// </summary>
		CurrencyCode CurrencyCode { get; }
		/// <summary>
		/// 	For social interactions, a value representing the social network being tracked.
		/// </summary>
		SocialInteractionNetwork SocialInteractionNetwork { get; }
		/// <summary>
		/// 	For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)
		/// </summary>
		SocialInteractionAction SocialInteractionAction { get; }
		/// <summary>
		/// 	For social interactions, a value representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1)
		/// </summary>
		SocialInteractionNetworkAction SocialInteractionNetworkAction { get; }
		/// <summary>
		/// 	For social interactions, a value representing the URL (or resource) which receives the social network action.
		/// </summary>
		SocialInteractionTarget SocialInteractionTarget { get; }
		/// <summary>
		/// 	Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged".
		/// </summary>
		SocialEngagementType SocialEngagementType { get; }
		/// <summary>
		/// 	A string for categorizing all user timing variables into logical groups for easier reporting purposes.
		/// </summary>
		UserTimingCategory UserTimingCategory { get; }
		/// <summary>
		/// 	The name of the resource's action being tracked.
		/// </summary>
		UserTimingLabel UserTimingLabel { get; }
		/// <summary>
		/// 	A value that can be used to add flexibility in visualizing user timings in the reports.
		/// </summary>
		UserTimingVariable UserTimingVariable { get; }
		/// <summary>
		/// 	The description for the exception.
		/// </summary>
		ExceptionDescription ExceptionDescription { get; }
		/// <summary>
		/// 	The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.
		/// </summary>
		ExperimentId ExperimentId { get; }
		/// <summary>
		/// 	The user-scoped id of the particular variation that the user was exposed to during a content experiment.
		/// </summary>
		ExperimentVariant ExperimentVariant { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 1 refers the number/index of the custom dimension.
		/// </summary>
		Dimension1 Dimension1 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 2 refers the number/index of the custom dimension.
		/// </summary>
		Dimension2 Dimension2 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 3 refers the number/index of the custom dimension.
		/// </summary>
		Dimension3 Dimension3 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 4 refers the number/index of the custom dimension.
		/// </summary>
		Dimension4 Dimension4 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 5 refers the number/index of the custom dimension.
		/// </summary>
		Dimension5 Dimension5 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 6 refers the number/index of the custom dimension.
		/// </summary>
		Dimension6 Dimension6 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 7 refers the number/index of the custom dimension.
		/// </summary>
		Dimension7 Dimension7 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 8 refers the number/index of the custom dimension.
		/// </summary>
		Dimension8 Dimension8 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 9 refers the number/index of the custom dimension.
		/// </summary>
		Dimension9 Dimension9 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 10 refers the number/index of the custom dimension.
		/// </summary>
		Dimension10 Dimension10 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 11 refers the number/index of the custom dimension.
		/// </summary>
		Dimension11 Dimension11 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 12 refers the number/index of the custom dimension.
		/// </summary>
		Dimension12 Dimension12 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 13 refers the number/index of the custom dimension.
		/// </summary>
		Dimension13 Dimension13 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 14 refers the number/index of the custom dimension.
		/// </summary>
		Dimension14 Dimension14 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 15 refers the number/index of the custom dimension.
		/// </summary>
		Dimension15 Dimension15 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 16 refers the number/index of the custom dimension.
		/// </summary>
		Dimension16 Dimension16 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 17 refers the number/index of the custom dimension.
		/// </summary>
		Dimension17 Dimension17 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 18 refers the number/index of the custom dimension.
		/// </summary>
		Dimension18 Dimension18 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 19 refers the number/index of the custom dimension.
		/// </summary>
		Dimension19 Dimension19 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 20 refers the number/index of the custom dimension.
		/// </summary>
		Dimension20 Dimension20 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 21 refers the number/index of the custom dimension.
		/// </summary>
		Dimension21 Dimension21 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 22 refers the number/index of the custom dimension.
		/// </summary>
		Dimension22 Dimension22 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 23 refers the number/index of the custom dimension.
		/// </summary>
		Dimension23 Dimension23 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 24 refers the number/index of the custom dimension.
		/// </summary>
		Dimension24 Dimension24 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 25 refers the number/index of the custom dimension.
		/// </summary>
		Dimension25 Dimension25 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 26 refers the number/index of the custom dimension.
		/// </summary>
		Dimension26 Dimension26 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 27 refers the number/index of the custom dimension.
		/// </summary>
		Dimension27 Dimension27 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 28 refers the number/index of the custom dimension.
		/// </summary>
		Dimension28 Dimension28 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 29 refers the number/index of the custom dimension.
		/// </summary>
		Dimension29 Dimension29 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 30 refers the number/index of the custom dimension.
		/// </summary>
		Dimension30 Dimension30 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 31 refers the number/index of the custom dimension.
		/// </summary>
		Dimension31 Dimension31 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 32 refers the number/index of the custom dimension.
		/// </summary>
		Dimension32 Dimension32 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 33 refers the number/index of the custom dimension.
		/// </summary>
		Dimension33 Dimension33 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 34 refers the number/index of the custom dimension.
		/// </summary>
		Dimension34 Dimension34 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 35 refers the number/index of the custom dimension.
		/// </summary>
		Dimension35 Dimension35 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 36 refers the number/index of the custom dimension.
		/// </summary>
		Dimension36 Dimension36 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 37 refers the number/index of the custom dimension.
		/// </summary>
		Dimension37 Dimension37 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 38 refers the number/index of the custom dimension.
		/// </summary>
		Dimension38 Dimension38 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 39 refers the number/index of the custom dimension.
		/// </summary>
		Dimension39 Dimension39 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 40 refers the number/index of the custom dimension.
		/// </summary>
		Dimension40 Dimension40 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 41 refers the number/index of the custom dimension.
		/// </summary>
		Dimension41 Dimension41 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 42 refers the number/index of the custom dimension.
		/// </summary>
		Dimension42 Dimension42 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 43 refers the number/index of the custom dimension.
		/// </summary>
		Dimension43 Dimension43 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 44 refers the number/index of the custom dimension.
		/// </summary>
		Dimension44 Dimension44 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 45 refers the number/index of the custom dimension.
		/// </summary>
		Dimension45 Dimension45 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 46 refers the number/index of the custom dimension.
		/// </summary>
		Dimension46 Dimension46 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 47 refers the number/index of the custom dimension.
		/// </summary>
		Dimension47 Dimension47 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 48 refers the number/index of the custom dimension.
		/// </summary>
		Dimension48 Dimension48 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 49 refers the number/index of the custom dimension.
		/// </summary>
		Dimension49 Dimension49 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 50 refers the number/index of the custom dimension.
		/// </summary>
		Dimension50 Dimension50 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 51 refers the number/index of the custom dimension.
		/// </summary>
		Dimension51 Dimension51 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 52 refers the number/index of the custom dimension.
		/// </summary>
		Dimension52 Dimension52 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 53 refers the number/index of the custom dimension.
		/// </summary>
		Dimension53 Dimension53 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 54 refers the number/index of the custom dimension.
		/// </summary>
		Dimension54 Dimension54 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 55 refers the number/index of the custom dimension.
		/// </summary>
		Dimension55 Dimension55 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 56 refers the number/index of the custom dimension.
		/// </summary>
		Dimension56 Dimension56 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 57 refers the number/index of the custom dimension.
		/// </summary>
		Dimension57 Dimension57 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 58 refers the number/index of the custom dimension.
		/// </summary>
		Dimension58 Dimension58 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 59 refers the number/index of the custom dimension.
		/// </summary>
		Dimension59 Dimension59 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 60 refers the number/index of the custom dimension.
		/// </summary>
		Dimension60 Dimension60 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 61 refers the number/index of the custom dimension.
		/// </summary>
		Dimension61 Dimension61 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 62 refers the number/index of the custom dimension.
		/// </summary>
		Dimension62 Dimension62 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 63 refers the number/index of the custom dimension.
		/// </summary>
		Dimension63 Dimension63 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 64 refers the number/index of the custom dimension.
		/// </summary>
		Dimension64 Dimension64 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 65 refers the number/index of the custom dimension.
		/// </summary>
		Dimension65 Dimension65 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 66 refers the number/index of the custom dimension.
		/// </summary>
		Dimension66 Dimension66 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 67 refers the number/index of the custom dimension.
		/// </summary>
		Dimension67 Dimension67 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 68 refers the number/index of the custom dimension.
		/// </summary>
		Dimension68 Dimension68 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 69 refers the number/index of the custom dimension.
		/// </summary>
		Dimension69 Dimension69 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 70 refers the number/index of the custom dimension.
		/// </summary>
		Dimension70 Dimension70 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 71 refers the number/index of the custom dimension.
		/// </summary>
		Dimension71 Dimension71 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 72 refers the number/index of the custom dimension.
		/// </summary>
		Dimension72 Dimension72 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 73 refers the number/index of the custom dimension.
		/// </summary>
		Dimension73 Dimension73 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 74 refers the number/index of the custom dimension.
		/// </summary>
		Dimension74 Dimension74 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 75 refers the number/index of the custom dimension.
		/// </summary>
		Dimension75 Dimension75 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 76 refers the number/index of the custom dimension.
		/// </summary>
		Dimension76 Dimension76 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 77 refers the number/index of the custom dimension.
		/// </summary>
		Dimension77 Dimension77 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 78 refers the number/index of the custom dimension.
		/// </summary>
		Dimension78 Dimension78 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 79 refers the number/index of the custom dimension.
		/// </summary>
		Dimension79 Dimension79 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 80 refers the number/index of the custom dimension.
		/// </summary>
		Dimension80 Dimension80 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 81 refers the number/index of the custom dimension.
		/// </summary>
		Dimension81 Dimension81 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 82 refers the number/index of the custom dimension.
		/// </summary>
		Dimension82 Dimension82 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 83 refers the number/index of the custom dimension.
		/// </summary>
		Dimension83 Dimension83 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 84 refers the number/index of the custom dimension.
		/// </summary>
		Dimension84 Dimension84 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 85 refers the number/index of the custom dimension.
		/// </summary>
		Dimension85 Dimension85 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 86 refers the number/index of the custom dimension.
		/// </summary>
		Dimension86 Dimension86 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 87 refers the number/index of the custom dimension.
		/// </summary>
		Dimension87 Dimension87 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 88 refers the number/index of the custom dimension.
		/// </summary>
		Dimension88 Dimension88 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 89 refers the number/index of the custom dimension.
		/// </summary>
		Dimension89 Dimension89 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 90 refers the number/index of the custom dimension.
		/// </summary>
		Dimension90 Dimension90 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 91 refers the number/index of the custom dimension.
		/// </summary>
		Dimension91 Dimension91 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 92 refers the number/index of the custom dimension.
		/// </summary>
		Dimension92 Dimension92 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 93 refers the number/index of the custom dimension.
		/// </summary>
		Dimension93 Dimension93 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 94 refers the number/index of the custom dimension.
		/// </summary>
		Dimension94 Dimension94 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 95 refers the number/index of the custom dimension.
		/// </summary>
		Dimension95 Dimension95 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 96 refers the number/index of the custom dimension.
		/// </summary>
		Dimension96 Dimension96 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 97 refers the number/index of the custom dimension.
		/// </summary>
		Dimension97 Dimension97 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 98 refers the number/index of the custom dimension.
		/// </summary>
		Dimension98 Dimension98 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 99 refers the number/index of the custom dimension.
		/// </summary>
		Dimension99 Dimension99 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 100 refers the number/index of the custom dimension.
		/// </summary>
		Dimension100 Dimension100 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 101 refers the number/index of the custom dimension.
		/// </summary>
		Dimension101 Dimension101 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 102 refers the number/index of the custom dimension.
		/// </summary>
		Dimension102 Dimension102 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 103 refers the number/index of the custom dimension.
		/// </summary>
		Dimension103 Dimension103 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 104 refers the number/index of the custom dimension.
		/// </summary>
		Dimension104 Dimension104 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 105 refers the number/index of the custom dimension.
		/// </summary>
		Dimension105 Dimension105 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 106 refers the number/index of the custom dimension.
		/// </summary>
		Dimension106 Dimension106 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 107 refers the number/index of the custom dimension.
		/// </summary>
		Dimension107 Dimension107 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 108 refers the number/index of the custom dimension.
		/// </summary>
		Dimension108 Dimension108 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 109 refers the number/index of the custom dimension.
		/// </summary>
		Dimension109 Dimension109 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 110 refers the number/index of the custom dimension.
		/// </summary>
		Dimension110 Dimension110 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 111 refers the number/index of the custom dimension.
		/// </summary>
		Dimension111 Dimension111 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 112 refers the number/index of the custom dimension.
		/// </summary>
		Dimension112 Dimension112 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 113 refers the number/index of the custom dimension.
		/// </summary>
		Dimension113 Dimension113 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 114 refers the number/index of the custom dimension.
		/// </summary>
		Dimension114 Dimension114 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 115 refers the number/index of the custom dimension.
		/// </summary>
		Dimension115 Dimension115 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 116 refers the number/index of the custom dimension.
		/// </summary>
		Dimension116 Dimension116 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 117 refers the number/index of the custom dimension.
		/// </summary>
		Dimension117 Dimension117 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 118 refers the number/index of the custom dimension.
		/// </summary>
		Dimension118 Dimension118 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 119 refers the number/index of the custom dimension.
		/// </summary>
		Dimension119 Dimension119 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 120 refers the number/index of the custom dimension.
		/// </summary>
		Dimension120 Dimension120 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 121 refers the number/index of the custom dimension.
		/// </summary>
		Dimension121 Dimension121 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 122 refers the number/index of the custom dimension.
		/// </summary>
		Dimension122 Dimension122 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 123 refers the number/index of the custom dimension.
		/// </summary>
		Dimension123 Dimension123 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 124 refers the number/index of the custom dimension.
		/// </summary>
		Dimension124 Dimension124 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 125 refers the number/index of the custom dimension.
		/// </summary>
		Dimension125 Dimension125 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 126 refers the number/index of the custom dimension.
		/// </summary>
		Dimension126 Dimension126 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 127 refers the number/index of the custom dimension.
		/// </summary>
		Dimension127 Dimension127 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 128 refers the number/index of the custom dimension.
		/// </summary>
		Dimension128 Dimension128 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 129 refers the number/index of the custom dimension.
		/// </summary>
		Dimension129 Dimension129 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 130 refers the number/index of the custom dimension.
		/// </summary>
		Dimension130 Dimension130 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 131 refers the number/index of the custom dimension.
		/// </summary>
		Dimension131 Dimension131 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 132 refers the number/index of the custom dimension.
		/// </summary>
		Dimension132 Dimension132 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 133 refers the number/index of the custom dimension.
		/// </summary>
		Dimension133 Dimension133 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 134 refers the number/index of the custom dimension.
		/// </summary>
		Dimension134 Dimension134 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 135 refers the number/index of the custom dimension.
		/// </summary>
		Dimension135 Dimension135 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 136 refers the number/index of the custom dimension.
		/// </summary>
		Dimension136 Dimension136 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 137 refers the number/index of the custom dimension.
		/// </summary>
		Dimension137 Dimension137 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 138 refers the number/index of the custom dimension.
		/// </summary>
		Dimension138 Dimension138 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 139 refers the number/index of the custom dimension.
		/// </summary>
		Dimension139 Dimension139 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 140 refers the number/index of the custom dimension.
		/// </summary>
		Dimension140 Dimension140 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 141 refers the number/index of the custom dimension.
		/// </summary>
		Dimension141 Dimension141 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 142 refers the number/index of the custom dimension.
		/// </summary>
		Dimension142 Dimension142 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 143 refers the number/index of the custom dimension.
		/// </summary>
		Dimension143 Dimension143 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 144 refers the number/index of the custom dimension.
		/// </summary>
		Dimension144 Dimension144 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 145 refers the number/index of the custom dimension.
		/// </summary>
		Dimension145 Dimension145 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 146 refers the number/index of the custom dimension.
		/// </summary>
		Dimension146 Dimension146 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 147 refers the number/index of the custom dimension.
		/// </summary>
		Dimension147 Dimension147 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 148 refers the number/index of the custom dimension.
		/// </summary>
		Dimension148 Dimension148 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 149 refers the number/index of the custom dimension.
		/// </summary>
		Dimension149 Dimension149 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 150 refers the number/index of the custom dimension.
		/// </summary>
		Dimension150 Dimension150 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 151 refers the number/index of the custom dimension.
		/// </summary>
		Dimension151 Dimension151 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 152 refers the number/index of the custom dimension.
		/// </summary>
		Dimension152 Dimension152 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 153 refers the number/index of the custom dimension.
		/// </summary>
		Dimension153 Dimension153 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 154 refers the number/index of the custom dimension.
		/// </summary>
		Dimension154 Dimension154 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 155 refers the number/index of the custom dimension.
		/// </summary>
		Dimension155 Dimension155 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 156 refers the number/index of the custom dimension.
		/// </summary>
		Dimension156 Dimension156 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 157 refers the number/index of the custom dimension.
		/// </summary>
		Dimension157 Dimension157 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 158 refers the number/index of the custom dimension.
		/// </summary>
		Dimension158 Dimension158 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 159 refers the number/index of the custom dimension.
		/// </summary>
		Dimension159 Dimension159 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 160 refers the number/index of the custom dimension.
		/// </summary>
		Dimension160 Dimension160 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 161 refers the number/index of the custom dimension.
		/// </summary>
		Dimension161 Dimension161 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 162 refers the number/index of the custom dimension.
		/// </summary>
		Dimension162 Dimension162 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 163 refers the number/index of the custom dimension.
		/// </summary>
		Dimension163 Dimension163 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 164 refers the number/index of the custom dimension.
		/// </summary>
		Dimension164 Dimension164 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 165 refers the number/index of the custom dimension.
		/// </summary>
		Dimension165 Dimension165 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 166 refers the number/index of the custom dimension.
		/// </summary>
		Dimension166 Dimension166 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 167 refers the number/index of the custom dimension.
		/// </summary>
		Dimension167 Dimension167 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 168 refers the number/index of the custom dimension.
		/// </summary>
		Dimension168 Dimension168 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 169 refers the number/index of the custom dimension.
		/// </summary>
		Dimension169 Dimension169 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 170 refers the number/index of the custom dimension.
		/// </summary>
		Dimension170 Dimension170 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 171 refers the number/index of the custom dimension.
		/// </summary>
		Dimension171 Dimension171 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 172 refers the number/index of the custom dimension.
		/// </summary>
		Dimension172 Dimension172 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 173 refers the number/index of the custom dimension.
		/// </summary>
		Dimension173 Dimension173 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 174 refers the number/index of the custom dimension.
		/// </summary>
		Dimension174 Dimension174 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 175 refers the number/index of the custom dimension.
		/// </summary>
		Dimension175 Dimension175 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 176 refers the number/index of the custom dimension.
		/// </summary>
		Dimension176 Dimension176 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 177 refers the number/index of the custom dimension.
		/// </summary>
		Dimension177 Dimension177 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 178 refers the number/index of the custom dimension.
		/// </summary>
		Dimension178 Dimension178 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 179 refers the number/index of the custom dimension.
		/// </summary>
		Dimension179 Dimension179 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 180 refers the number/index of the custom dimension.
		/// </summary>
		Dimension180 Dimension180 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 181 refers the number/index of the custom dimension.
		/// </summary>
		Dimension181 Dimension181 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 182 refers the number/index of the custom dimension.
		/// </summary>
		Dimension182 Dimension182 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 183 refers the number/index of the custom dimension.
		/// </summary>
		Dimension183 Dimension183 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 184 refers the number/index of the custom dimension.
		/// </summary>
		Dimension184 Dimension184 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 185 refers the number/index of the custom dimension.
		/// </summary>
		Dimension185 Dimension185 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 186 refers the number/index of the custom dimension.
		/// </summary>
		Dimension186 Dimension186 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 187 refers the number/index of the custom dimension.
		/// </summary>
		Dimension187 Dimension187 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 188 refers the number/index of the custom dimension.
		/// </summary>
		Dimension188 Dimension188 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 189 refers the number/index of the custom dimension.
		/// </summary>
		Dimension189 Dimension189 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 190 refers the number/index of the custom dimension.
		/// </summary>
		Dimension190 Dimension190 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 191 refers the number/index of the custom dimension.
		/// </summary>
		Dimension191 Dimension191 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 192 refers the number/index of the custom dimension.
		/// </summary>
		Dimension192 Dimension192 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 193 refers the number/index of the custom dimension.
		/// </summary>
		Dimension193 Dimension193 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 194 refers the number/index of the custom dimension.
		/// </summary>
		Dimension194 Dimension194 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 195 refers the number/index of the custom dimension.
		/// </summary>
		Dimension195 Dimension195 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 196 refers the number/index of the custom dimension.
		/// </summary>
		Dimension196 Dimension196 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 197 refers the number/index of the custom dimension.
		/// </summary>
		Dimension197 Dimension197 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 198 refers the number/index of the custom dimension.
		/// </summary>
		Dimension198 Dimension198 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 199 refers the number/index of the custom dimension.
		/// </summary>
		Dimension199 Dimension199 { get; }
		/// <summary>
		/// 	The name of the requested custom dimension, where 200 refers the number/index of the custom dimension.
		/// </summary>
		Dimension200 Dimension200 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName1 CustomVarName1 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName2 CustomVarName2 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName3 CustomVarName3 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName4 CustomVarName4 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName5 CustomVarName5 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName6 CustomVarName6 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName7 CustomVarName7 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName8 CustomVarName8 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName9 CustomVarName9 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName10 CustomVarName10 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName11 CustomVarName11 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName12 CustomVarName12 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName13 CustomVarName13 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName14 CustomVarName14 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName15 CustomVarName15 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName16 CustomVarName16 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName17 CustomVarName17 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName18 CustomVarName18 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName19 CustomVarName19 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName20 CustomVarName20 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName21 CustomVarName21 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName22 CustomVarName22 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName23 CustomVarName23 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName24 CustomVarName24 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName25 CustomVarName25 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName26 CustomVarName26 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName27 CustomVarName27 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName28 CustomVarName28 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName29 CustomVarName29 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName30 CustomVarName30 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName31 CustomVarName31 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName32 CustomVarName32 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName33 CustomVarName33 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName34 CustomVarName34 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName35 CustomVarName35 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName36 CustomVarName36 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName37 CustomVarName37 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName38 CustomVarName38 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName39 CustomVarName39 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName40 CustomVarName40 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName41 CustomVarName41 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName42 CustomVarName42 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName43 CustomVarName43 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName44 CustomVarName44 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName45 CustomVarName45 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName46 CustomVarName46 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName47 CustomVarName47 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName48 CustomVarName48 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName49 CustomVarName49 { get; }
		/// <summary>
		/// 	The name for the requested custom variable.
		/// </summary>
		CustomVarName50 CustomVarName50 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue1 CustomVarValue1 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue2 CustomVarValue2 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue3 CustomVarValue3 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue4 CustomVarValue4 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue5 CustomVarValue5 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue6 CustomVarValue6 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue7 CustomVarValue7 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue8 CustomVarValue8 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue9 CustomVarValue9 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue10 CustomVarValue10 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue11 CustomVarValue11 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue12 CustomVarValue12 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue13 CustomVarValue13 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue14 CustomVarValue14 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue15 CustomVarValue15 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue16 CustomVarValue16 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue17 CustomVarValue17 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue18 CustomVarValue18 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue19 CustomVarValue19 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue20 CustomVarValue20 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue21 CustomVarValue21 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue22 CustomVarValue22 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue23 CustomVarValue23 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue24 CustomVarValue24 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue25 CustomVarValue25 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue26 CustomVarValue26 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue27 CustomVarValue27 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue28 CustomVarValue28 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue29 CustomVarValue29 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue30 CustomVarValue30 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue31 CustomVarValue31 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue32 CustomVarValue32 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue33 CustomVarValue33 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue34 CustomVarValue34 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue35 CustomVarValue35 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue36 CustomVarValue36 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue37 CustomVarValue37 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue38 CustomVarValue38 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue39 CustomVarValue39 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue40 CustomVarValue40 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue41 CustomVarValue41 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue42 CustomVarValue42 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue43 CustomVarValue43 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue44 CustomVarValue44 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue45 CustomVarValue45 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue46 CustomVarValue46 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue47 CustomVarValue47 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue48 CustomVarValue48 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue49 CustomVarValue49 { get; }
		/// <summary>
		/// 	The value for the requested custom variable.
		/// </summary>
		CustomVarValue50 CustomVarValue50 { get; }
		/// <summary>
		/// 	The date of the session formatted as YYYYMMDD.
		/// </summary>
		Date Date { get; }
		/// <summary>
		/// 	The year of the session. A four-digit year from 2005 to the current year.
		/// </summary>
		Year Year { get; }
		/// <summary>
		/// 	The month of the session. A two digit integer from 01 to 12.
		/// </summary>
		Month Month { get; }
		/// <summary>
		/// 	The week of the session. A two-digit number from 01 to 53. Each week starts on Sunday.
		/// </summary>
		Week Week { get; }
		/// <summary>
		/// 	The day of the month. A two-digit number from 01 to 31.
		/// </summary>
		Day Day { get; }
		/// <summary>
		/// 	A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This value is also corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone follows daylight savings time, there will be an apparent bump in the number of sessions during the change-over hour (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero sessions will occur at the opposite changeover. (Google Analytics does not track user time more precisely than hours.)
		/// </summary>
		Hour Hour { get; }
		/// <summary>
		/// 	Returns the minute in the hour. The possible values are between 00 and 59.
		/// </summary>
		Minute Minute { get; }
		/// <summary>
		/// 	Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.
		/// </summary>
		NthMonth NthMonth { get; }
		/// <summary>
		/// 	Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries.
		/// </summary>
		NthWeek NthWeek { get; }
		/// <summary>
		/// 	Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on.
		/// </summary>
		NthDay NthDay { get; }
		/// <summary>
		/// 	Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.
		/// </summary>
		NthMinute NthMinute { get; }
		/// <summary>
		/// 	The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).
		/// </summary>
		DayOfWeek DayOfWeek { get; }
		/// <summary>
		/// 	The name of the day of the week (in English).
		/// </summary>
		DayOfWeekName DayOfWeekName { get; }
		/// <summary>
		/// 	Combined values of ga:date and ga:hour.
		/// </summary>
		DateHour DateHour { get; }
		/// <summary>
		/// 	Combined values of ga:year and ga:month.
		/// </summary>
		YearMonth YearMonth { get; }
		/// <summary>
		/// 	Combined values of ga:year and ga:week.
		/// </summary>
		YearWeek YearWeek { get; }
		/// <summary>
		/// 	The ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoWeek should only be used with ga:isoYear since ga:year represents gregorian calendar.
		/// </summary>
		IsoWeek IsoWeek { get; }
		/// <summary>
		/// 	The ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.
		/// </summary>
		IsoYear IsoYear { get; }
		/// <summary>
		/// 	Combined values of ga:isoYear and ga:isoWeek.
		/// </summary>
		IsoYearIsoWeek IsoYearIsoWeek { get; }
		/// <summary>
		/// 	DCM ad name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickAd DcmClickAd { get; }
		/// <summary>
		/// 	DCM ad ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickAdId DcmClickAdId { get; }
		/// <summary>
		/// 	DCM ad type name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickAdType DcmClickAdType { get; }
		/// <summary>
		/// 	DCM ad type ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickAdTypeId DcmClickAdTypeId { get; }
		/// <summary>
		/// 	DCM advertiser name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickAdvertiser DcmClickAdvertiser { get; }
		/// <summary>
		/// 	DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickAdvertiserId DcmClickAdvertiserId { get; }
		/// <summary>
		/// 	DCM campaign name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickCampaign DcmClickCampaign { get; }
		/// <summary>
		/// 	DCM campaign ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickCampaignId DcmClickCampaignId { get; }
		/// <summary>
		/// 	DCM creative ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickCreativeId DcmClickCreativeId { get; }
		/// <summary>
		/// 	DCM creative name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickCreative DcmClickCreative { get; }
		/// <summary>
		/// 	DCM rendering ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickRenderingId DcmClickRenderingId { get; }
		/// <summary>
		/// 	DCM creative type name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickCreativeType DcmClickCreativeType { get; }
		/// <summary>
		/// 	DCM creative type ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickCreativeTypeId DcmClickCreativeTypeId { get; }
		/// <summary>
		/// 	DCM creative version of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickCreativeVersion DcmClickCreativeVersion { get; }
		/// <summary>
		/// 	Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickSite DcmClickSite { get; }
		/// <summary>
		/// 	DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickSiteId DcmClickSiteId { get; }
		/// <summary>
		/// 	DCM site placement name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickSitePlacement DcmClickSitePlacement { get; }
		/// <summary>
		/// 	DCM site placement ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickSitePlacementId DcmClickSitePlacementId { get; }
		/// <summary>
		/// 	DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		DcmClickSpotId DcmClickSpotId { get; }
		/// <summary>
		/// 	DCM Floodlight activity name associated with the floodlight conversion (premium only).
		/// </summary>
		DcmFloodlightActivity DcmFloodlightActivity { get; }
		/// <summary>
		/// 	DCM Floodlight activity name and group name associated with the floodlight conversion (premium only).
		/// </summary>
		DcmFloodlightActivityAndGroup DcmFloodlightActivityAndGroup { get; }
		/// <summary>
		/// 	DCM Floodlight activity group name associated with the floodlight conversion (premium only).
		/// </summary>
		DcmFloodlightActivityGroup DcmFloodlightActivityGroup { get; }
		/// <summary>
		/// 	DCM Floodlight activity group ID associated with the floodlight conversion (premium only).
		/// </summary>
		DcmFloodlightActivityGroupId DcmFloodlightActivityGroupId { get; }
		/// <summary>
		/// 	DCM Floodlight activity ID associated with the floodlight conversion (premium only).
		/// </summary>
		DcmFloodlightActivityId DcmFloodlightActivityId { get; }
		/// <summary>
		/// 	DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).
		/// </summary>
		DcmFloodlightAdvertiserId DcmFloodlightAdvertiserId { get; }
		/// <summary>
		/// 	DCM Floodlight configuration ID associated with the floodlight conversion (premium only).
		/// </summary>
		DcmFloodlightSpotId DcmFloodlightSpotId { get; }
		/// <summary>
		/// 	DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventAd DcmLastEventAd { get; }
		/// <summary>
		/// 	DCM ad ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventAdId DcmLastEventAdId { get; }
		/// <summary>
		/// 	DCM ad type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventAdType DcmLastEventAdType { get; }
		/// <summary>
		/// 	DCM ad type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventAdTypeId DcmLastEventAdTypeId { get; }
		/// <summary>
		/// 	DCM advertiser name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventAdvertiser DcmLastEventAdvertiser { get; }
		/// <summary>
		/// 	DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventAdvertiserId DcmLastEventAdvertiserId { get; }
		/// <summary>
		/// 	There are two possible values: ClickThrough and ViewThrough. If the last DCM event associated with the Google Analytics session was a click, then the value will be ClickThrough. If the last DCM event associated with the Google Analytics session was an ad impression, then the value will be ViewThrough (premium only).
		/// </summary>
		DcmLastEventAttributionType DcmLastEventAttributionType { get; }
		/// <summary>
		/// 	DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventCampaign DcmLastEventCampaign { get; }
		/// <summary>
		/// 	DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventCampaignId DcmLastEventCampaignId { get; }
		/// <summary>
		/// 	DCM creative ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventCreativeId DcmLastEventCreativeId { get; }
		/// <summary>
		/// 	DCM creative name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventCreative DcmLastEventCreative { get; }
		/// <summary>
		/// 	DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventRenderingId DcmLastEventRenderingId { get; }
		/// <summary>
		/// 	DCM creative type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventCreativeType DcmLastEventCreativeType { get; }
		/// <summary>
		/// 	DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventCreativeTypeId DcmLastEventCreativeTypeId { get; }
		/// <summary>
		/// 	DCM creative version of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventCreativeVersion DcmLastEventCreativeVersion { get; }
		/// <summary>
		/// 	Site name where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventSite DcmLastEventSite { get; }
		/// <summary>
		/// 	DCM site ID where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventSiteId DcmLastEventSiteId { get; }
		/// <summary>
		/// 	DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventSitePlacement DcmLastEventSitePlacement { get; }
		/// <summary>
		/// 	DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventSitePlacementId DcmLastEventSitePlacementId { get; }
		/// <summary>
		/// 	DCM Floodlight configuration ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		DcmLastEventSpotId DcmLastEventSpotId { get; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		LandingContentGroup1 LandingContentGroup1 { get; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		LandingContentGroup2 LandingContentGroup2 { get; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		LandingContentGroup3 LandingContentGroup3 { get; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		LandingContentGroup4 LandingContentGroup4 { get; }
		/// <summary>
		/// 	Content group of a user's landing page.
		/// </summary>
		LandingContentGroup5 LandingContentGroup5 { get; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		PreviousContentGroup1 PreviousContentGroup1 { get; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		PreviousContentGroup2 PreviousContentGroup2 { get; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		PreviousContentGroup3 PreviousContentGroup3 { get; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		PreviousContentGroup4 PreviousContentGroup4 { get; }
		/// <summary>
		/// 	Refers to content group that was visited before another content group.
		/// </summary>
		PreviousContentGroup5 PreviousContentGroup5 { get; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		ContentGroup1 ContentGroup1 { get; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		ContentGroup2 ContentGroup2 { get; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		ContentGroup3 ContentGroup3 { get; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		ContentGroup4 ContentGroup4 { get; }
		/// <summary>
		/// 	Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules.
		/// </summary>
		ContentGroup5 ContentGroup5 { get; }
		/// <summary>
		/// 	Age bracket of user.
		/// </summary>
		UserAgeBracket UserAgeBracket { get; }
		/// <summary>
		/// 	Gender of user.
		/// </summary>
		UserGender UserGender { get; }
		/// <summary>
		/// 	Indicates that users are more likely to be interested in learning about the specified category, and more likely to be ready to purchase.
		/// </summary>
		InterestOtherCategory InterestOtherCategory { get; }
		/// <summary>
		/// 	Indicates that users are more likely to be interested in learning about the specified category.
		/// </summary>
		InterestAffinityCategory InterestAffinityCategory { get; }
		/// <summary>
		/// 	Indicates that users are more likely to be ready to purchase products or services in the specified category.
		/// </summary>
		InterestInMarketCategory InterestInMarketCategory { get; }
		/// <summary>
		/// 	The browser size used by users to your website. For example, 1024x768.
		/// </summary>
		BrowserSize BrowserSize { get; }
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_id campaign tracking parameter.
		/// </summary>
		CampaignCode CampaignCode { get; }
		/// <summary>
		/// 	The default channel grouping that is shared within the View (Profile).
		/// </summary>
		ChannelGrouping ChannelGrouping { get; }
		/// <summary>
		/// 	User options specified during the checkout process, e.g., FedEx, DHL, UPS for delivery options or Visa, MasterCard, AmEx for payment options. This dimension should be used along with ga:shoppingStage (Enhanced Ecommerce).
		/// </summary>
		CheckoutOptions CheckoutOptions { get; }
		/// <summary>
		/// 	The city IDs of users, derived from IP addresses or Geographical IDs. The city IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
		/// </summary>
		CityId CityId { get; }
		/// <summary>
		/// 	Correlation Model ID for related products.
		/// </summary>
		CorrelationModelId CorrelationModelId { get; }
		/// <summary>
		/// 	The country ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-1 alpha-2 code.
		/// </summary>
		CountryIsoCode CountryIsoCode { get; }
		/// <summary>
		/// 	The data source of a hit. By default, hits sent from ga.js and analytics.js are reported as "web". Hits sent from the mobile SDKs are reported as "app". These values can be overridden in the Measurement Protocol.
		/// </summary>
		DataSource DataSource { get; }
		/// <summary>
		/// 	The creative content designed for a promotion (Enhanced Ecommerce).
		/// </summary>
		InternalPromotionCreative InternalPromotionCreative { get; }
		/// <summary>
		/// 	The ID of the promotion (Enhanced Ecommerce).
		/// </summary>
		InternalPromotionId InternalPromotionId { get; }
		/// <summary>
		/// 	The name of the promotion (Enhanced Ecommerce).
		/// </summary>
		InternalPromotionName InternalPromotionName { get; }
		/// <summary>
		/// 	The position of the promotion on the web page or application screen (Enhanced Ecommerce).
		/// </summary>
		InternalPromotionPosition InternalPromotionPosition { get; }
		/// <summary>
		/// 	Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.
		/// </summary>
		IsTrueViewVideoAd IsTrueViewVideoAd { get; }
		/// <summary>
		/// 	Index for each hour in the specified date range. Index for the first hour of first day (i.e., start-date) in the date range is 0, 1 for the next hour, and so on.
		/// </summary>
		NthHour NthHour { get; }
		/// <summary>
		/// 	Code for the order-level coupon (Enhanced Ecommerce).
		/// </summary>
		OrderCouponCode OrderCouponCode { get; }
		/// <summary>
		/// 	The brand name under which the product is sold (Enhanced Ecommerce).
		/// </summary>
		ProductBrand ProductBrand { get; }
		/// <summary>
		/// 	The hierarchical category in which the product is classified (Enhanced Ecommerce).
		/// </summary>
		ProductCategoryHierarchy ProductCategoryHierarchy { get; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		ProductCategoryLevel1 ProductCategoryLevel1 { get; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		ProductCategoryLevel2 ProductCategoryLevel2 { get; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		ProductCategoryLevel3 ProductCategoryLevel3 { get; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		ProductCategoryLevel4 ProductCategoryLevel4 { get; }
		/// <summary>
		/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
		/// </summary>
		ProductCategoryLevel5 ProductCategoryLevel5 { get; }
		/// <summary>
		/// 	Code for the product-level coupon (Enhanced Ecommerce).
		/// </summary>
		ProductCouponCode ProductCouponCode { get; }
		/// <summary>
		/// 	The name of the product list in which the product appears (Enhanced Ecommerce).
		/// </summary>
		ProductListName ProductListName { get; }
		/// <summary>
		/// 	The position of the product in the product list (Enhanced Ecommerce).
		/// </summary>
		ProductListPosition ProductListPosition { get; }
		/// <summary>
		/// 	The specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce).
		/// </summary>
		ProductVariant ProductVariant { get; }
		/// <summary>
		/// 	ID of the product being queried.
		/// </summary>
		QueryProductId QueryProductId { get; }
		/// <summary>
		/// 	Name of the product being queried.
		/// </summary>
		QueryProductName QueryProductName { get; }
		/// <summary>
		/// 	Variation of the product being queried.
		/// </summary>
		QueryProductVariation QueryProductVariation { get; }
		/// <summary>
		/// 	The region ID of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York. The region IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
		/// </summary>
		RegionId RegionId { get; }
		/// <summary>
		/// 	The region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code.
		/// </summary>
		RegionIsoCode RegionIsoCode { get; }
		/// <summary>
		/// 	ID of the related product.
		/// </summary>
		RelatedProductId RelatedProductId { get; }
		/// <summary>
		/// 	Name of the related product.
		/// </summary>
		RelatedProductName RelatedProductName { get; }
		/// <summary>
		/// 	Variation of the related product.
		/// </summary>
		RelatedProductVariation RelatedProductVariation { get; }
		/// <summary>
		/// 	Various stages of the shopping experience that users completed in a session, e.g., PRODUCT_VIEW, ADD_TO_CART, CHECKOUT, etc. (Enhanced Ecommerce).
		/// </summary>
		ShoppingStage ShoppingStage { get; }
		/// <summary>
		/// 	The sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code.
		/// </summary>
		SubContinentCode SubContinentCode { get; }
	}
}

