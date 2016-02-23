# LinqAn.Google
LinqAn (LINQ ANalytics, pronounced "Lincoln") is a .NET companion library for analytics platforms,
allowing for LINQ-based queries. LinqAn.Google is the Google version, which uses Google Analytics
Core Reporting API v3. Currently this supports the .NET 4.5 framework, in addition to DNX 4.5.1.


## Overview

This project lets you query Google Analytics with the help fo LINQ. This library uses the Google
Analytics Core Reproting API v3 for .NET, abstracting away much of the work that is done. As an
end user, using LINQ over Google Analytics is fun.

The dimensions and metrics are strongly typed, so you can never make a mistake. There are enough
comments to help you out along the way, and you can always have a discussion over at the 
[issues page](https://github.com/kenshinthebattosai/LinqAn.Google/issues).

You can query like this:

```
// IAnalyticsProfile supports Service Account Authorzization
var profile = new LinqAn.Google.Profiles.AnalyticsProfile(serviceAccountEmail,
                    keyFilePath, applicationName);

// This is the context over which queries can be executed
var googleAnalytics = new LinqAn.Google.AnalyticsContext(profile);

// Records can be filtered and sorted
var records = googleAnalytics.Records
                // View Id - Always Required
                .Where(x => x.ViewId == viewId)
                // Start Date, End Date - Always Required
                .Where(x => x.RecordDate == DateTime.Today)
                // Include Dimensions
                .Include(x => x.Source)
                .Include(x => x.Medium)
                // Include Metrics - At least one required
                .Include(x => x.Pageviews)
                .Include(x => x.Sessions)
                .Include(x => x.SessionDuration)
                // Filters
                .Where(x => x.Country == "India" && x.Medium == new Regex("organic"))
                .Where(x => x.Source.Contains("a") && !x.Source.Contains("x"))
                .Where(x => x.SessionDuration > TimeSpan.FromMinutes(1))
                // Sort - Only by those included
                .OrderByDescending(x => x.SessionDuration)
                .ThenBy(x => x.Source)
                // Skip 1 record
                .Skip(1)
                // Take only 5 records
                .Take(5);

foreach(var record in records)
    // do whatever you want!
```

## Running the Sample
The sample project provided runs in DNX4.5.1 to make use of DNX. It needs 2 crucial files in order
to work. It works with a Service Account Credential. Other methods can be found
[here](https://developers.google.com/api-client-library/dotnet/get_started). You can also pass
a `BaseClientService.Initializer` instance to the `AnalyticsContext` to query over.

To run the sample project, you need a service account. More details on this can be found
[here](https://developers.google.com/identity/protocols/OAuth2#serviceaccount). After you complete
the outlined process to get a service account and have added it to the appropriate profile (view),
add a `gasettings.json` file to the root of the samples project folder
`$/samples/LinqAn.Google.Sample` with the following content:
```
{
  "profile": {
    "application_name": "YOUE_APP_NAME",
    "key_file_name": "PATH_TO_KEY_FILE_FROM_PROJECT_ROOT.p12",
    "service_account_email": "YOUR_SERVICE_ACCOUNT_EMAIL@obviously.com",
    "view_id": XXXXXXXX
  }
}
```
Of course, you have to enter your original values. Copy the key file to the project root at the
appropriate location you mentioned in your `gasettings.json` file, and you're good to go.

## Concerns, Suggestions, and Feedback

I'm always interested in these. Please submit these via the
[issues page](https://github.com/kenshinthebattosai/LinqAn.Google/issues). I will personally get
back to you. In case you are submitting an issue, please check the existing issues list, just to be
sure that your submission isn't a duplicate.
