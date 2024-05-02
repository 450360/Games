using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace InitialApp
{
   public class JobDataParser_4cornerresources : IDataParser
   {
      public IEnumerable<string> Parse(string url)
      {
         string html = null!;
         using (HttpClient client = new HttpClient())
         {
            html = client.GetStringAsync(url).Result;
         }

         HtmlParser parser = new HtmlParser();
         IDocument page = parser.ParseDocument(html);
         return page.QuerySelectorAll("li")
         .Where(x => x.ParentElement != null
         && x.ParentElement.ParentElement != null
         && x.ParentElement.ParentElement.ClassName == "letter-section")
         .Select(x => x.TextContent.Trim());
      }
   }
}