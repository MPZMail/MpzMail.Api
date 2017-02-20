#MpzMail C# API

Install-Package MpzMail.Api

###nuget
The package is available on [nuget](https://www.nuget.org/packages/MpzMail.Api/)
```
PM> Install-Package MpzMail.Api
```

###Example
```cs
IXmlParser parser = new DefaultXmlParser();
IHttpClient httpClient = new DefaultHttpClient();
IMpzWrapper wrapper = new MpzWrapper(parser, httpClient, "00000-apikey", "https://mpzmail.com/api/v3.0/");

var campaigns = wrapper.GetCampaigns();
```
