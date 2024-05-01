using System;

namespace InitialApp
{
   public class DefaultPersonGenerator : IPersonGenerator
   {
      private Random _rnd = new Random();

      public Person Create(PersonGenOptions options = default)
      {
         char sex = _rnd.Next(2) == 0 ? 'M' : 'F';
         sex = options.sex ?? sex;

         string name = sex == 'M' ? Data.maleNames.GetRandom() : Data.femaleNames.GetRandom();
         name = options.name ?? name;

         string surname = sex == 'M' ? Data.maleSurnames.GetRandom() : Data.femaleSurnames.GetRandom();
         surname = options.surname ?? surname;

         DateTime birthDate = Utils.RandomDate(DateTime.Today);
         birthDate = options.birthDate ?? birthDate;

         return new Person(name, surname, birthDate, sex);
      }
   }
}