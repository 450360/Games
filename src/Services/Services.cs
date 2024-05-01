namespace InitialApp
{
   /// <summary>
   /// Service locator
   /// </summary>
   public static class Services
   {
      /* ---------------------------------- props --------------------------------- */
      public static IMsgOutput msgOutput { get; private set; } = new DefaultOutput();
      public static IPersonGenerator personGenerator { get; private set; } = new DefaultPersonGenerator();

      /* ---------------------------------- init ---------------------------------- */
      public static void Init
      (
         IMsgOutput msgOutput,
         IPersonGenerator personGenerator
      )
      {
         Services.msgOutput = msgOutput;
         Services.personGenerator = personGenerator;
      }
   }
}