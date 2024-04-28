
namespace InitialApp
{
   public class DefaultOutput : IMsgOutput
   {
      public void Print(string message, ConsoleColor? foregroundColor = null)
      {
         ConsoleColor prevColor = Console.ForegroundColor;
         Console.ForegroundColor = foregroundColor ?? prevColor;
         System.Console.WriteLine(message);
         Console.ForegroundColor = prevColor;
      }
   }
}