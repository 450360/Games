namespace InitialApp
{
   public static partial class Utils
   {
      public static int GetFullYears(DateTime date)
      {
         DateTime current = DateTime.Today;
         int result = current.Year - date.Year;
         bool overMonth = current.Month > date.Month;
         bool sameMonth = current.Month == date.Month;
         bool sameDay_or_overDay = current.Day >= date.Day;
         if (overMonth || (sameMonth && sameDay_or_overDay)) return result;
         return result - 1;
      }
   }
}