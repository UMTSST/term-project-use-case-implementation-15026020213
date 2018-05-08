using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase
{
    class Database
    {
        InterFace interf;
        public Database()
        {
            interf = new InterFace();
        }

        public void GetRecordFromFile()
        {
            try
            {
                StreamReader sr = new StreamReader("Record.txt");
                string Bookinfo;
                while ((Bookinfo = sr.ReadLine()) != null)
                {
                    interf.DisplayRecord(Bookinfo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be opened");
                Console.WriteLine(e.Message);
            }
        }
    }
}
