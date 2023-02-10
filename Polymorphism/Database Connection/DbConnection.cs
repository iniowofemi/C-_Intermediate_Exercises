using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {

        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public abstract void OpenConnection(string ConnectionString);

        public abstract void CloseConnection();     
    }
}
