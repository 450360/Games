namespace InitialApp
{
   /// <summary>
   /// Person wrapper class.
   /// Represents person's age and provides age methods.
   /// </summary>
   public class PersonAge
   {
      /* ---------------------------------- props --------------------------------- */
      public Person person { get; private set; }
      public int age => Utils.FullYears(this.person.birthDate);

      /* ---------------------------------- init ---------------------------------- */
      public PersonAge(Person person)
      {
         this.person = person;
      }

      /* ---------------------------------- funcs --------------------------------- */
      public virtual void AskAge()
      {
         Services.msgOutput.Print($"I'm {this.age} y/o");
      }
   }
}