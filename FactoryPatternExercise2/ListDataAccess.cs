using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
        //Constructor
		public ListDataAccess()
		{
		}

        //Implementation of methods from the IDataAccess interface
        public void LoadData()
        {
            Console.WriteLine("I am reading data from the List Data Access."); 
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Database.");
        }
    }
}

