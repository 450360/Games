namespace InitialApp
{
   public class Person
   {
      /* ---------------------------------- props --------------------------------- */
      public string name { get; private set; }
      public string surname { get; private set; }
      public DateTime birthDate { get; private set; }

      /* ---------------------------------- init ---------------------------------- */
      public Person(string name, string surname, DateTime birthDate)
      {
         this.name = name;
         this.surname = surname;
         this.birthDate = birthDate;
      }

      /* ---------------------------------- funcs --------------------------------- */
      public virtual void SayHello()
      {
         Services.msgOutput.Print($"Hello.");
      }

      public virtual void AskName()
      {
         Services.msgOutput.Print($"My name is {this.name}.");
      }

      public virtual void AskMonthOfBirth()
      {
         Services.msgOutput.Print($"I was born in {(Months)birthDate.Month}.");
      }
   }
}