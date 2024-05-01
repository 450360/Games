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
         IList<string> maleNames = null!,
         IList<string> femaleNames = null!,
         IList<string> maleSurnames = null!,
         IList<string> femaleSurnames = null!
      )
      {
         Data.maleNames = maleNames != null ? maleNames.AsReadOnly() : Data.maleNames;
         Data.femaleNames = femaleNames != null ? femaleNames.AsReadOnly() : Data.femaleNames;
         Data.maleSurnames = maleSurnames != null ? maleSurnames.AsReadOnly() : Data.maleSurnames;
         Data.femaleSurnames = femaleSurnames != null ? femaleSurnames.AsReadOnly() : Data.femaleSurnames;
      }
   }
}