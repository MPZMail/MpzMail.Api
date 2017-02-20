#MpzMail C# API

**Example**

    IXmlParser parser = new DefaultXmlParser();
    IHttpClient httpClient = new DefaultHttpClient();
    IMpzWrapper wrapper = new MpzWrapper(parser, httpClient, "00000-apikey", "https://mpzmail.com/api/v3.0/");

    var campaigns = wrapper.GetCampaigns();