using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace InitialApp
{
   public class WebDataReader : IDataReader
   {
      public IList<string> Read(string url)
      {
         IParser parser = null!;
         if (url.Contains("names.mongabay.com")) parser = new NameDataParser();
         else throw new NotImplementedException();
         return parser.Parse(url).ToList();
      }
   }
}