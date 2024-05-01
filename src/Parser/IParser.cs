namespace InitialApp
{
   public interface IParser
   {
      IEnumerable<string> Parse(string url);
   }
}