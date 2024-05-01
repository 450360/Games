namespace InitialApp
{
   public class TxtDataReader : IDataReader
   {
      /* ---------------------------------- funcs --------------------------------- */
      public IList<string> Read(string path)
      {
         string text = File.ReadAllText(path);
         return text.Trim().Split('\n');
      }
   }
}