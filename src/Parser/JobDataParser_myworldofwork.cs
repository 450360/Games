using AngleSharp.Html.Parser;

namespace InitialApp
{
   public class JobDataParser_myworldofwork : IDataParser
   {
      public IEnumerable<string> Parse(string url)
      {
         string html = null!;
         using (HttpClient client = new HttpClient())
         {
            html = client.GetStringAsync(url).Result;
         }

         return new HtmlParser()
         .ParseDocument(html)
         .QuerySelectorAll("div")
         .Where(x => x.ClassName == "job-profile")
         .Select(x => x.FirstElementChild!.TextContent.Trim());
      }
   }
}