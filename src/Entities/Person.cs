using System.Text;

namespace InitialApp
{
   /// <summary>
   /// Represents person
   /// </summary>
   public class Person
   {
      /* ---------------------------------- props --------------------------------- */
      public string name { get; private set; }
      public string surname { get; private set; }
      public DateTime birthDate { get; private set; }
      public char sex { get; private set; }

      /* ---------------------------------- init ---------------------------------- */
      public Person(string name, string surname, DateTime birthDate, char sex)
      {
         this.name = name;
         this.surname = surname;
         this.birthDate = birthDate;
         this.sex = char.ToUpper(sex);
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

      public override string ToString()
      {
         StringBuilder result = new StringBuilder();
         result.Append($"name: {name}\n");
         result.Append($"surname: {surname}\n");
         result.Append($"birthDate: {birthDate}\n");
         result.Append($"sex: {sex}");
         return result.ToString();
      }

   }
}