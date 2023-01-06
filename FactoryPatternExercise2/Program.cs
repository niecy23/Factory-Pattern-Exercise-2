namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? Please enter: List, SQL, or Mongo?");
            var userInput = Console.ReadLine();

            IDataAccess databaseOutput =  DataAccessFactory.GetDataAccessType(userInput);

            databaseOutput.LoadData();
            databaseOutput.SaveData();

        }
    }
}
