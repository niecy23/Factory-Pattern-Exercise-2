using System;
namespace FactoryPatternExercise2
{
	public static class DataAccessFactory
	{
		//Method to create a new instance of a database based on inputted data
		//that is changed to lowercase text before entering the switch
		public static IDataAccess GetDataAccessType(string databaseType)
		{
			switch (databaseType.ToLower())
			{
				case "list":
					return new ListDataAccess();

				case "sql":
					return new SQLDataAccess();

				case "mongo":
					return new MongoDataAccess();
	
				default:
					return new ListDataAccess();
				
			}
		}
	}
}

