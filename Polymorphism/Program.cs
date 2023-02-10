namespace DatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Would you like to open a connection to the SQL Dabatase or the Oracle Database?");
            var connectionString = System.Console.ReadLine();

            if (connectionString != null)
            {
                if (connectionString == "SQL")
                {
                    var sqlConnection = new SqlConnection();
                    sqlConnection.OpenConnection(connectionString);
                }
                else if (connectionString == "Oracle")
                {
                    var oracleConnection = new OracleConnection();
                    oracleConnection.OpenConnection(connectionString);
                }
                else
                {
                    System.Console.WriteLine("Invalid entry");
                }
            }
            else
                System.Console.WriteLine("You entered null");
        }
    }
}
