using System;

namespace InitialApp
{
   public class Program
   {
      public static void Main(string[] args)
      {
         Person person = new Person("Nikita", "Fokin", new DateTime(1991, 10, 28));
         person.SayHello();
         person.AskName();
         person.AskMonthOfBirth();
      }
   }
}