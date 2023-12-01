using System.Data.Common;
namespace Intermediate
{
    class OracleConnection:DbConnection
    {
        public OracleConnection(string connectionString):base(connectionString)
        {
            
        }
         public override void Open()
        {
            System.Console.WriteLine(" Oracle Connection OPEN{0}" ,connectionString );
        }
        public override void Close()
        {
            System.Console.WriteLine(" Oracle Connection Close{0}" ,connectionString);
            
        }
    }
}