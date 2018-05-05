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
            try
            {
                StreamReader sr = new StreamReader("Record.txt");
                string Bookinfo;
                while ((Bookinfo = sr.ReadLine()) != null)
                {
                    Console.WriteLine(Bookinfo);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be opened");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
