namespace InitialApp
{
   public interface IPersonGenerator
   {
      Person Create(PersonGenOptions options = new());
   }
}