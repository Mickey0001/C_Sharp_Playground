using System;
using System.IO;
using System.Net;

namespace ScrapeClient
{
    public class Scrape
    {
           public string ScrapeWebpage(string url)
    {
        return GetWebpage(url);
    }

    public string ScrapeWebpage(string url, string filepath)
    {
        string reply = GetWebpage(url);

        File.WriteAllText(filepath, reply);
        return reply;
    }

    private string GetWebpage(string url)
    {
        WebClient client = new WebClient();
        return client.DownloadString(url);
    }
    }
}
 

