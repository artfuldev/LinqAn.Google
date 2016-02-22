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
		/// 	Total number of 1-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 1 day period ending on the given date.
		/// </summary>
		public OnedayUsers OnedayUsers { get; set; }
		/// <summary>
		/// 	Total number of 7-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 7 day period ending on the given date.
		/// </summary>
		public SevendayUsers SevendayUsers { get; set; }
		/// <summary>
		/// 	Total number of 14-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date.
		/// </summary>
		public FourteendayUsers FourteendayUsers { get; set; }
		/// <summary>
		/// 	Total number of 30-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 30 day period ending on the given date.
		/// </summary>
		public ThirtydayUsers ThirtydayUsers { get; set; }
		/// <summary>
		/// 	The total number of sessions.
		/// </summary>
		public Sessions Sessions { get; set; }
		/// <summary>
		/// 	The total number of single page (or single engagement hit) sessions for your property.
		/// </summary>
		public Bounces Bounces { get; set; }
		/// <summary>
		/// 	The total duration of user sessions represented in total seconds.
		/// </summary>
		public SessionDuration SessionDuration { get; set; }
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
		/// 	The total number of starts for all goals defined for your profile.
		/// </summary>
		public GoalStartsAll GoalStartsAll { get; set; }
		/// <summary>
		/// 	The total number of completions for all goals defined for your profile.
		/// </summary>
		public GoalCompletionsAll GoalCompletionsAll { get; set; }
		/// <summary>
		/// 	The total numeric value for all goals defined for your profile.
		/// </summary>
		public GoalValueAll GoalValueAll { get; set; }
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
		/// 	The total number of pageviews for your property.
		/// </summary>
		public Pageviews Pageviews { get; set; }
		/// <summary>
		/// 	The number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness.
		/// </summary>
		public UniquePageviews UniquePageviews { get; set; }
		/// <summary>
		/// 	How long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.
		/// </summary>
		public TimeOnPage TimeOnPage { get; set; }
		/// <summary>
		/// 	The number of exits from your property.
		/// </summary>
		public Exits Exits { get; set; }
		/// <summary>
		/// 	The number of times a search result page was viewed after performing a search.
		/// </summary>
		public SearchResultViews SearchResultViews { get; set; }
		/// <summary>
		/// 	The total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once.
		/// </summary>
		public SearchUniques SearchUniques { get; set; }
		/// <summary>
		/// 	The total number of sessions that included an internal search
		/// </summary>
		public SearchSessions SearchSessions { get; set; }
		/// <summary>
		/// 	The total number of subsequent page views made after a use of your internal search feature.
		/// </summary>
		public SearchDepth SearchDepth { get; set; }
		/// <summary>
		/// 	The total number of times a refinement (transition) occurs between internal search keywords within a session. For example if the sequence of keywords is: "shoes", "shoes", "pants", "pants", this metric will be one because the transition between "shoes" and "pants" is different.
		/// </summary>
		public SearchRefinements SearchRefinements { get; set; }
		/// <summary>
		/// 	The session duration where a use of your internal search feature occurred.
		/// </summary>
		public SearchDuration SearchDuration { get; set; }
		/// <summary>
		/// 	The number of exits on your site that occurred following a search result from your internal search feature.
		/// </summary>
		public SearchExits SearchExits { get; set; }
		/// <summary>
		/// 	Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
		/// </summary>
		public PageLoadTime PageLoadTime { get; set; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the average page load time.
		/// </summary>
		public PageLoadSample PageLoadSample { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.
		/// </summary>
		public DomainLookupTime DomainLookupTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) to download this page among all samples.
		/// </summary>
		public PageDownloadTime PageDownloadTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.
		/// </summary>
		public RedirectionTime RedirectionTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.
		/// </summary>
		public ServerConnectionTime ServerConnectionTime { get; set; }
		/// <summary>
		/// 	The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.
		/// </summary>
		public ServerResponseTime ServerResponseTime { get; set; }
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
		/// </summary>
		public SpeedMetricsSample SpeedMetricsSample { get; set; }
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.
		/// </summary>
		public DomInteractiveTime DomInteractiveTime { get; set; }
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.
		/// </summary>
		public DomContentLoadedTime DomContentLoadedTime { get; set; }
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
		/// 	The total number of sessions with events.
		/// </summary>
		public SessionsWithEvent SessionsWithEvent { get; set; }
		/// <summary>
		/// 	The total number of transactions.
		/// </summary>
		public Transactions Transactions { get; set; }
		/// <summary>
		/// 	The total sale revenue provided in the transaction excluding shipping and tax.
		/// </summary>
		public TransactionRevenue TransactionRevenue { get; set; }
		/// <summary>
		/// 	The total cost of shipping.
		/// </summary>
		public TransactionShipping TransactionShipping { get; set; }
		/// <summary>
		/// 	The total amount of tax.
		/// </summary>
		public TransactionTax TransactionTax { get; set; }
		/// <summary>
		/// 	The total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased.
		/// </summary>
		public ItemQuantity ItemQuantity { get; set; }
		/// <summary>
		/// 	The number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased.
		/// </summary>
		public UniquePurchases UniquePurchases { get; set; }
		/// <summary>
		/// 	The total revenue from purchased product items.
		/// </summary>
		public ItemRevenue ItemRevenue { get; set; }
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
		/// 	The total number of milliseconds for a user timing.
		/// </summary>
		public UserTimingValue UserTimingValue { get; set; }
		/// <summary>
		/// 	The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.
		/// </summary>
		public UserTimingSample UserTimingSample { get; set; }
		/// <summary>
		/// 	The number of exceptions that were sent to Google Analytics.
		/// </summary>
		public Exceptions Exceptions { get; set; }
		/// <summary>
		/// 	The number of exceptions where isFatal is set to true.
		/// </summary>
		public FatalExceptions FatalExceptions { get; set; }
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

