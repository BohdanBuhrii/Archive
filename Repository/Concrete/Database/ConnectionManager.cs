using System;
using System.Configuration;
using System.Data.Common;


namespace Repository.Concrete.Database
{
    public class ConnectionManager : IDisposable
    {
        protected const string connectionType = "Npgsql";
        protected readonly DbProviderFactory factory = DbProviderFactories.GetFactory(connectionType);
        protected DbConnection connection;
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    connection.Dispose();
                }

                connection.Close();

                // Note disposing has been done.
                disposed = true;
            }
        }


        ~ConnectionManager()
        {
            Dispose(false);
        }

        public ConnectionManager()
        {
            connection = factory.CreateConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["ARCHIVE"].ConnectionString;
            connection.Open();
        }
      

        public void ExecuteNonQuery(string textOfCommand)
        {
            DbCommand command = factory.CreateCommand();

            command.Connection = connection;
            command.CommandText = textOfCommand;

            command.ExecuteNonQuery();
        }


        public object ExecuteScalar(string textOfCommand)
        {
            DbCommand command = factory.CreateCommand();

            command.Connection = connection;
            command.CommandText = textOfCommand;

            object scalar = command.ExecuteScalar();

            return scalar;
        }


        public DbDataReader ExecuteReader(string textOfCommand)
        {
            using (DbCommand command = factory.CreateCommand())
            {
                command.Connection = connection;
                command.CommandText = textOfCommand;

                DbDataReader reader = command.ExecuteReader();
                
                return reader;
            }

        }


        public void RefreshDataReader()
        {
            connection.Dispose();
            connection = factory.CreateConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["UTILITYCOMPANY"].ConnectionString;
            connection.Open();
        }
    }
}
