using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase
{
    class TestCase
    {
        bool check;
        public bool CheckFile()
        {
            FileInfo file = new FileInfo("Record.txt");
            if (!file.Exists)
            {
                Console.WriteLine("File doesnot exists");
                return false;
            }
            else
            {
                if(file.Length == 0)
                {
                    Console.WriteLine("File is empty");
                    return false;
                }
                else
                {
                    Console.WriteLine("File is Okay");
                }
            }
            return true;
        }
    }
}
