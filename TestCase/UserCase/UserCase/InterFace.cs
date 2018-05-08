using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase
{
    class InterFace
    {
        public void DisplayRecord(string record)
        {
            Console.WriteLine(record.Replace("|","---"));
        }

    }
}
