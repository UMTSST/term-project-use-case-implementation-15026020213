using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            db.GetRecordFromFile();
            Console.ReadKey();
        }
    }
}
