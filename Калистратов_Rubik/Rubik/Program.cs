using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rubik
{
    class Program
    {
         
        static void Main(string[] args)
        {
            string file;
            file = System.Console.ReadLine();
            foreach (string str in InputOutput.getFileContent(file))
            {
                System.Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
