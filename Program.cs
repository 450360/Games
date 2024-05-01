using System;

namespace InitialApp
{
   public class Program
   {
      public static void Main(string[] args)
      {
         //use custom data for creating 10 random persons

         TxtDataReader dataReader = new TxtDataReader();
         IList<string> maleNames = dataReader.Read("data/male_names.txt");
         Data.Init(maleNames: maleNames);

         PersonGenOptions options = new PersonGenOptions();
         options.sex = 'M';
         for (int i = 0; i < 10; i++)
         {
            options.birthDate = new DateTime(1997, 1, 1).RandomMonth().RandomDay();
            Person p = Services.personGenerator.Create(options);
            System.Console.WriteLine(p);
            System.Console.WriteLine("------------");
         }
      }
   }
}