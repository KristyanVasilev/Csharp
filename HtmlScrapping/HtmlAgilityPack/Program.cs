// From File
using HtmlAgilityPack;
using System.Text;

internal class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var url = "https://recepti.gotvach.bg/r-225119";

        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage response = client.GetAsync(url).Result)
            {
                using (HttpContent content = response.Content)
                {
                    string result = content.ReadAsStringAsync().Result;
                    var htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(result);

                    Console.WriteLine(htmlDocument.DocumentNode.InnerText);

                    Console.WriteLine(htmlDocument.ToString());
                }
            }
        }
    }
}