using System;
using System.Data.Common;
namespace Intermediate
{
    class DbCommand
    {
        private DbConnection dpConnection;
        private string instruction;
        public DbCommand(DbConnection dpConnection, string instruction)
        {
            if(dpConnection == null)
            {
                throw new InvalidOperationException("Data base connection Can not be null");
            }
            if(string.IsNullOrEmpty(instruction))
            {
                throw new InvalidOperationException("instructions can not be empty");

            }
            this.dpConnection = dpConnection;
            this.instruction = instruction;
        }

        public void Excute()
        {
            dpConnection.Open();
            System.Console.WriteLine("Run Instructions : {0}" , instruction);
            dpConnection.Close();
        }
    }
}