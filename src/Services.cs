namespace InitialApp
{
   /// <summary>
   /// Service locator
   /// </summary>
   public static class Services
   {
      /* ---------------------------------- props --------------------------------- */
      public static IMsgOutput msgOutput { get; private set; } = new DefaultOutput();

      /* ---------------------------------- init ---------------------------------- */
      public static void Init(IMsgOutput msgOutput)
      {
         Services.msgOutput = msgOutput;
      }
   }
}