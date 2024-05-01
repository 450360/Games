
using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace InitialApp
{
   public class NameDataParser : IParser
   {
      public IEnumerable<string> Parse(string url)
      {
         string html = null!;
         using (HttpClient client = new HttpClient())
         {
            html = client.GetStringAsync(url).Result;
         }

         HtmlParser parser = new HtmlParser();
         IDocument document = parser.ParseDocument(html);
         return document.QuerySelectorAll("tr").Select(x => x.FirstElementChild!.TextContent.Capitalize()).Skip(1);
      }
   }
}