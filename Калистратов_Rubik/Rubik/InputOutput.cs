using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik
{
    public class InputOutput
    {
        public static string[] getFileContent(string filename)
        {
            string line;
            string[] mainArr = new string[6];
            System.IO.StreamReader file = null;
            try
            {
                file = new System.IO.StreamReader(filename);
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Console.WriteLine("File not found!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            int count = 0;
            while ((line = file.ReadLine()) != null)
            {
                mainArr[count++] = line;
            }
            //  System.Console.WriteLine(mainArr[2][2]);
            file.Close();
            return mainArr;
        }

       
    }
}
