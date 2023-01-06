using System;
namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
        //Constructor
        public MongoDataAccess()
		{
		}

        //Implementation of methods from the IDataAccess interface
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from the Mongo Data Access.");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo database.");
        }
    }
}

