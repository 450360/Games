using System.Runtime.CompilerServices;

namespace InitialApp
{
   /// <summary>
   /// Useful extensions for all cases
   /// </summary>
   public static class Extensions
   {
      private static Random _rnd = new Random();

      public static T GetRandom<T>(this IList<T> lst) => lst[_rnd.Next(0, lst.Count)];

      public static DateTime RandomYear(this DateTime date)
      {
         int year = _rnd.Next(0, DateTime.MaxValue.Year + 1);
         int month = date.Month;
         int day = DayCap(year, month, date.Day);
         return new DateTime(year, month, day);
      }

      public static DateTime RandomMonth(this DateTime date)
      {
         int year = date.Year;
         int month = _rnd.Next(1, 13);
         int day = DayCap(year, month, date.Day);
         return new DateTime(year, month, day);
      }

      public static DateTime RandomDay(this DateTime date)
      => new DateTime(date.Year, date.Month, _rnd.Next(1, DateTime.DaysInMonth(date.Year, date.Month) + 1));

      /* ---------------------------------- logic --------------------------------- */
      private static int DayCap(int year, int month, int day)
      {
         int daysInMonth = DateTime.DaysInMonth(year, month);
         return day > daysInMonth ? daysInMonth : day;
      }
   }
}