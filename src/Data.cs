using System.Collections.ObjectModel;

namespace InitialApp
{
   /// <summary>
   /// Data locator
   /// </summary>
   public static class Data
   {
      /* ---------------------------------- props --------------------------------- */
      public static ReadOnlyCollection<string> maleNames { get; private set; }
      = new string[] { "Nikolai", "Mihail", "Evgeniy" }.AsReadOnly();

      public static ReadOnlyCollection<string> femaleNames { get; private set; }
      = new string[] { "Anastasia", "Natalia", "Ekaterina" }.AsReadOnly();

      public static ReadOnlyCollection<string> maleSurnames { get; private set; }
      = new string[] { "Makarov", "Kalashnikov", "Dragunov" }.AsReadOnly();

      public static ReadOnlyCollection<string> femaleSurnames { get; private set; }
      = new string[] { "Morozova", "Rusakova", "Samarina" }.AsReadOnly();

      /* ---------------------------------- init ---------------------------------- */
      public static void Init
      (
         IList<string> maleNames,
         IList<string> femaleNames,
         IList<string> maleSurnames,
         IList<string> femaleSurnames
      )
      {
         Data.maleNames = maleNames.AsReadOnly();
         Data.femaleNames = femaleNames.AsReadOnly();
         Data.maleSurnames = maleSurnames.AsReadOnly();
         Data.femaleSurnames = femaleSurnames.AsReadOnly();
      }
   }
}