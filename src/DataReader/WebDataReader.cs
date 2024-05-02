using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace InitialApp
{
   public class WebDataReader : IDataReader
   {
      public IList<string> Read(string url)
      {
         IDataParser parser = null!;
         if (url.Contains("names.mongabay.com"))
         {
            parser = new NameDataParser();
         }
         else if (url.Contains("4cornerresources.com/job-descriptions/"))
         {
            parser = new JobDataParser_4cornerresources();
         }
         else if (url.Contains("myworldofwork.co.uk/my-career-options/job-categories"))
         {
            parser = new JobDataParser_myworldofwork();
         }
         else throw new NotImplementedException();
         return parser.Parse(url).ToList();
      }
   }
}