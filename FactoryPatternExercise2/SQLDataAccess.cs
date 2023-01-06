using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
        //Constructor
        public SQLDataAccess()
		{
		}

        //Implementation of methods from the IDataAccess interface
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from the SQL Data Access.");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Database.");
        }
    }
}

