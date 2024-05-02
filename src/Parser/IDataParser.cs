namespace InitialApp
{
   public interface IDataParser
   {
      IEnumerable<string> Parse(string url);
   }
}