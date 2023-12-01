using System;
namespace Intermediate
{
    abstract class DbConnection
    {
        protected string connectionString;
        protected TimeSpan timeOut;
        public DbConnection(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString)) 
            {
                throw new InvalidOperationException("value can not be null");
            }
            this.connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}