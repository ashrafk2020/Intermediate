using System.Data.Common;
namespace Intermediate
{
    class SqlConnection:DbConnection
    {
        public SqlConnection(string connectionString):base(connectionString)
        {
            
        }
        public override void Open()
        {
            System.Console.WriteLine("SQL connection Open{0}" ,connectionString);
        }
        public override void Close()
        {
            System.Console.WriteLine("SQL connection Closed{0}" ,connectionString);
            
        }
    }
}