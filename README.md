# LinqAn.Google
LinqAn (LINQ ANalytics, pronounced "Lincoln") is a .NET companion library for analytics platforms,
allowing for LINQ-based queries. LinqAn.Google is the Google version, which uses Google Analytics
Core Reporting API v3. Currently this supports .NET 4.5 & 4.6 frameworks, in addition to DNX4.5.1.


## Documentation
### Under Construction
The aim of the project is to let you query Google Analytics this way:

```
var client = new LinqAn.Google.Client(profile);
var records = client.Records
                // Sample View Id
                .Where(x => x.ViewId == 1351215)
                // Dates
                .Where(x => x.Date == DateTime.Today)
                // Dimensions
                .Include(x => x.Source)
                .Include(x => x.Medium)
                // Metrics
                .Include(x => x.Hits)
                .Include(x => x.Sessions)
                .Include(x => x.SessionDuration)
                // Filters
                .Where(x=> x.Country == "India")
                // Sort
                .OrderByDescending(x => x.SessionDuration)
                .ThenBy(x => x.Hits);
```

To run the sample project,
add a `gasettings.json` file to the root of the samples project folder
($/samples/LinqAn.Google.Sample) with the following content:
```
{
  "profile": {
    "application_name": "Your application name",
    "key_file_name": "key.p12",
    "service_account_email": "someaccount@i.am.google.developer",
    "view_id": XXXXXXXX
  }
}
```
Of course, you have to enter your original values.