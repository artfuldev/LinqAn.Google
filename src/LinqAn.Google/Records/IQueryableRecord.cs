using LinqAn.Google.Metrics;
using LinqAn.Google.Dimensions;

namespace LinqAn.Google.Records
{
	public interface IQueryableRecord
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
		/// 	Total number of 1-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 1 day period ending on the given date.
		/// </summary>
		OnedayUsers OnedayUsers { get; }
		/// <summary>
		/// 	Total number of 7-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 7 day period ending on the given date.
		/// </summary>
		SevendayUsers SevendayUsers { get; }
		/// <summary>
		/// 	Total number of 14-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date.
		/// </summary>
		FourteendayUsers FourteendayUsers { get; }
		/// <summary>
		/// 	Total number of 30-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 30 day period ending on the given date.
		/// </summary>
		ThirtydayUsers ThirtydayUsers { get; }
		/// <summary>
		/// 	The total number of sessions.
		/// </summary>
		Sessions Sessions { get; }
		/// <summary>
		/// 	The total number of single page (or single engagement hit) sessions for your property.
		/// </summary>
		Bounces Bounces { get; }
		/// <summary>
		/// 	The total duration of user sessions represented in total seconds.
		/// </summary>
		SessionDuration SessionDuration { get; }
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
		/// 	The total number of starts for all goals defined for your profile.
		/// </summary>
		GoalStartsAll GoalStartsAll { get; }
		/// <summary>
		/// 	The total number of completions for all goals defined for your profile.
		/// </summary>
		GoalCompletionsAll GoalCompletionsAll { get; }
		/// <summary>
		/// 	The total numeric value for all goals defined for your profile.
		/// </summary>
		GoalValueAll GoalValueAll { get; }
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
		/// 	The total number of pageviews for your property.
		/// </summary>
		Pageviews Pageviews { get; }
		/// <summary>
		/// 	The number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		UniquePageviews UniquePageviews { get; }
		/// <summary>
		/// 	How long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.
		/// </summary>
		TimeOnPage TimeOnPage { get; }
		/// <summary>
		/// 	The number of exits from your property.
		/// </summary>
		Exits Exits { get; }
		/// <summary>
		/// 	The number of times a search result page was viewed after performing a search.
		/// </summary>
		SearchResultViews SearchResultViews { get; }
		/// <summary>
		/// 	The total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once.
		/// </summary>
		SearchUniques SearchUniques { get; }
		/// <summary>
		/// 	The total number of sessions that included an internal search
		/// </summary>
		SearchSessions SearchSessions { get; }
		/// <summary>
		/// 	The total number of subsequent page views made after a use of your internal search feature.
		/// </summary>
		SearchDepth SearchDepth { get; }
		/// <summary>
		/// 	The total number of times a refinement (transition) occurs between internal search keywords within a session. For example if the sequence of keywords is: "shoes", "shoes", "pants", "pants", this metric will be one because the transition between "shoes" and "pants" is different.
		/// </summary>
		SearchRefinements SearchRefinements { get; }
		/// <summary>
		/// 	The session duration where a use of your internal search feature occurred.
		/// </summary>
		SearchDuration SearchDuration { get; }
		/// <summary>
		/// 	The number of exits on your site that occurred following a search result from your internal search feature.
		/// </summary>
		SearchExits SearchExits { get; }
		/// <summary>
		/// 	Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
		/// </summary>
		PageLoadTime PageLoadTime { get; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the average page load time.
		/// </summary>
		PageLoadSample PageLoadSample { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.
		/// </summary>
		DomainLookupTime DomainLookupTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) to download this page among all samples.
		/// </summary>
		PageDownloadTime PageDownloadTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.
		/// </summary>
		RedirectionTime RedirectionTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.
		/// </summary>
		ServerConnectionTime ServerConnectionTime { get; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.
		/// </summary>
		ServerResponseTime ServerResponseTime { get; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
		/// </summary>
		SpeedMetricsSample SpeedMetricsSample { get; }
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.
		/// </summary>
		DomInteractiveTime DomInteractiveTime { get; }
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.
		/// </summary>
		DomContentLoadedTime DomContentLoadedTime { get; }
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
		/// 	The total number of sessions with events.
		/// </summary>
		SessionsWithEvent SessionsWithEvent { get; }
		/// <summary>
		/// 	The total number of transactions.
		/// </summary>
		Transactions Transactions { get; }
		/// <summary>
		/// 	The total sale revenue provided in the transaction excluding shipping and tax.
		/// </summary>
		TransactionRevenue TransactionRevenue { get; }
		/// <summary>
		/// 	The total cost of shipping.
		/// </summary>
		TransactionShipping TransactionShipping { get; }
		/// <summary>
		/// 	The total amount of tax.
		/// </summary>
		TransactionTax TransactionTax { get; }
		/// <summary>
		/// 	The total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased.
		/// </summary>
		ItemQuantity ItemQuantity { get; }
		/// <summary>
		/// 	The number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased.
		/// </summary>
		UniquePurchases UniquePurchases { get; }
		/// <summary>
		/// 	The total revenue from purchased product items.
		/// </summary>
		ItemRevenue ItemRevenue { get; }
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
		/// 	The total number of milliseconds for a user timing.
		/// </summary>
		UserTimingValue UserTimingValue { get; }
		/// <summary>
		/// 	The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.
		/// </summary>
		UserTimingSample UserTimingSample { get; }
		/// <summary>
		/// 	The number of exceptions that were sent to Google Analytics.
		/// </summary>
		Exceptions Exceptions { get; }
		/// <summary>
		/// 	The number of exceptions where isFatal is set to true.
		/// </summary>
		FatalExceptions FatalExceptions { get; }
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



