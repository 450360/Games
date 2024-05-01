using System;

namespace InitialApp
{
   public class Program
   {
      public static void Main(string[] args)
      {
         //download data from website
         Utils.UpdateData();

         // init data
         IDataReader dataReader = new TxtDataReader();
         Data.Init
         (
            maleNames: dataReader.Read("data/male_names.txt"),
            femaleNames: dataReader.Read("data/female_names.txt"),
            maleSurnames: dataReader.Read("data/surnames.txt"),
            femaleSurnames: dataReader.Read("data/surnames.txt")
         );

         // generate 10 random persons
         for (int i = 0; i < 10; i++)
         {
            System.Console.WriteLine(Services.personGenerator.Create());
            System.Console.WriteLine("----------");
         }
      }
   }
}