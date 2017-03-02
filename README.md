#MpzMail C# API

###Documentation
More information over the methods you can found [here](http://mpzmail.com/mpzapi/)

###nuget
The package is available on [nuget](https://www.nuget.org/packages/MpzMail.Api/)
```
PM> Install-Package MpzMail.Api
```

###Example
```cs
IXmlParser xmlParser = new DefaultXmlParser();
IHttpClient httpClient = new DefaultHttpClient();
IMpzWrapper wrapper = new MpzWrapper(xmlParser, httpClient, "your-apikey", "https://mpzmail.com/api/v3.0/");

var campaigns = wrapper.GetCampaigns();
```
