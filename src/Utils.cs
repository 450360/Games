namespace InitialApp
{
   /// <summary>
   /// Useful methods for all cases
   /// </summary>
   public static partial class Utils
   {
      private static Random _rnd = new Random();

      public static int FullYears(DateTime date)
      {
         DateTime current = DateTime.Today;
         int result = current.Year - date.Year;
         bool overMonth = current.Month > date.Month;
         bool sameMonth = current.Month == date.Month;
         bool sameDay_or_overDay = current.Day >= date.Day;
         if (overMonth || (sameMonth && sameDay_or_overDay)) return result;
         return result - 1;
      }

      public static DateTime RandomDate(DateTime max)
      {
         int year = _rnd.Next(0, max.Year);
         int month = _rnd.Next(1, 13);
         int day = _rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
         if (year == max.Year && month > max.Month)
         {
            month = max.Month;
            if (day > max.Day) day = max.Day;
         }
         return new DateTime(year, month, day);
      }

      public static void UpdateData()
      {
         IDataReader dataReader = new WebDataReader();
         dataReader.Read("https://names.mongabay.com/male_names.htm").WriteAs("data/male_names.txt");
         dataReader.Read("https://names.mongabay.com/female_names.htm").WriteAs("data/female_names.txt");
         dataReader.Read("https://names.mongabay.com/most_common_surnames.htm").WriteAs("data/surnames.txt");
      }
   }
}