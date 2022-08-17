using AngleSharp;

public class Program
{
    public static async Task Main(string[] args)
    {
        //Scrapping information from TopGear using AngleSharp only for educational purposes!
        var config = Configuration.Default.WithDefaultLoader();
        var context = BrowsingContext.New(config);

        var document = await context.OpenAsync("https://www.topgear.com/car-news/electric/top-gears-top-20-electric-cars");

        // get top 20 electric cars
        var electricCarsBrands = document.QuerySelectorAll("#main > div > ol > li > div.sc-bdfBQB.cylQah > div.sc-bdfBQB.foPALk > h2"); 
        //copy selecto and get the path

        var descriptions = document.QuerySelectorAll("#main > div > ol > li > div.sc-bdfBQB.cylQah > div.sc-bdfBQB.ghikhw > div > p:nth-child(1)");

        var imagesLinks = document.QuerySelectorAll("#main > div > ol > li > div.sc-bdfBQB.cylQah > div.sc-bdfBQB.hEhhZA > div > div > img");

        var listLinks = document.QuerySelectorAll("#main > div > ol > li > div > div.sc-bdfBQB.ghikhw > div > p:nth-child(2) > a");

        foreach (var carBrand in electricCarsBrands)
        {
            Console.WriteLine(carBrand.TextContent);
            Console.WriteLine("------------");
        }

        Console.WriteLine();

        foreach (var listLink in listLinks)
        {
            Console.WriteLine(listLink.GetAttribute("href"));
        }

        Console.WriteLine();

        foreach (var desc in descriptions)
        {
            Console.WriteLine(desc.TextContent);
            Console.WriteLine("------------");
           //Console.WriteLine(item.InnerHtml);
           //Console.WriteLine(item.OuterHtml);
           //Console.WriteLine(item.ToHtml());
           //Console.WriteLine(item);
        }

        Console.WriteLine();

        foreach (var image in imagesLinks)
        {
          Console.WriteLine("https://www.topgear.com/" + image.GetAttribute("src"));
        }
    }
}