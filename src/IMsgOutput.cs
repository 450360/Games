namespace InitialApp
{
   public interface IMsgOutput
   {
      void Print(string message, ConsoleColor? foregroundColor = null);
   }
}