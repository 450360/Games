namespace InitialApp
{
   public class LoopedInt
   {
      /* ---------------------------------- props --------------------------------- */
      public int min { get; private set; }
      public int max { get; private set; }
      public int current { get; private set; }

      /* ---------------------------------- init ---------------------------------- */
      public LoopedInt(int min, int max, int current)
      {
         this.min = min;
         this.max = max;
         this.current = current;
      }


      /* ---------------------------------- funcs --------------------------------- */
      public void Increment()
      {
         current++;
         if (current > max) current = min;
      }


      public void Decrement()
      {
         current--;
         if (current < min) current = max;
      }
   }
}