using System.Runtime.CompilerServices;

namespace InitialApp
{
   /// <summary>
   /// Useful extensions for all cases
   /// </summary>
   public static class Extensions
   {
      /* --------------------------------- fields --------------------------------- */
      private static Random _rnd = new Random();

      /* ---------------------------------- funcs --------------------------------- */
      public static T GetRandom<T>(this IList<T> lst) => lst[_rnd.Next(0, lst.Count)];

      public static DateTime RandomYear(this DateTime date)
      {
         int year = _rnd.Next(0, DateTime.MaxValue.Year + 1);
         int month = date.Month;
         int day = _DayCap(year, month, date.Day);
         return new DateTime(year, month, day);
      }

      public static DateTime RandomMonth(this DateTime date)
      {
         int year = date.Year;
         int month = _rnd.Next(1, 13);
         int day = _DayCap(year, month, date.Day);
         return new DateTime(year, month, day);
      }

      public static DateTime RandomDay(this DateTime date)
      => new DateTime(date.Year, date.Month, _rnd.Next(1, DateTime.DaysInMonth(date.Year, date.Month) + 1));

      public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
      {
         foreach (var item in collection)
         {
            action.Invoke(item);
         }
      }

      public static string Capitalize(this string str)
      => char.ToUpper(str[0]) + str.Substring(1).ToLower();

      public static void WriteAs(this IEnumerable<string> collection, string filePath)
      => File.WriteAllLines(filePath, collection);

      /* ---------------------------------- logic --------------------------------- */
      private static int _DayCap(int year, int month, int day)
      {
         int daysInMonth = DateTime.DaysInMonth(year, month);
         return day > daysInMonth ? daysInMonth : day;
      }
   }
}