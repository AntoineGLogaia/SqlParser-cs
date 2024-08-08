using SqlParser.Dialects;
using SqlParser;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string cmd = "ALTER TABLE `DpAssocies` DROP FOREIGN KEY `FK_DpAssocies_DpDossiers_DossierId`;";


            var ast = new Parser().ParseSql(cmd, new MySqlDialect());
        }
    }
}
