using System;

namespace InitialApp
{
   public class Program
   {
      public static void Main(string[] args)
      {
         //generate 2 random persons who born in 1997

         PersonGenOptions options = new PersonGenOptions();
         options.birthDate = new DateTime(1997, 1, 1).RandomMonth().RandomDay();
         Person p1 = Services.personGenerator.Create(options);
         System.Console.WriteLine(p1);

         System.Console.WriteLine("------------");

         options.birthDate = new DateTime(1997, 1, 1).RandomMonth().RandomDay();
         Person p2 = Services.personGenerator.Create(options);
         System.Console.WriteLine(p2);
      }
   }
}