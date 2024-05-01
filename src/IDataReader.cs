namespace InitialApp
{
   public interface IDataReader
   {
      IList<string> Read(string path);
   }
}