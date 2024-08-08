using SqlParser.Dialects;
using SqlParser;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string cmd = "ALTER TABLE `DcEcritures` DROP INDEX `index4`;";


            var ast = new Parser().ParseSql(cmd, new MySqlDialect());
        }
    }
}
