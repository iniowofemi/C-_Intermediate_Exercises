using System;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public override void OpenConnection(string ConnectionString)
        {
            Console.WriteLine("Connection to SQL Database opened.");

            var validAnswer = false;
            while (!validAnswer)
            {
                Console.WriteLine("Would you like to close the connection? (Y/N)");
                var choice = Console.ReadLine();
                if (choice == "N")
                {
                    validAnswer = true;
                    Console.WriteLine("Okay. The Connection will be held open.");
                }
                else if (choice == "Y")
                {
                    validAnswer = true;
                    CloseConnection();
                }
            }
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection to SQL Database closed.");
        }
    }
}
