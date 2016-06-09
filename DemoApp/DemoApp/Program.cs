using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = args[1];
            string input2 = args[2];
            string output = args[3];
            using (var writer = new StreamWriter(output))
            {
                writer.WriteLine("Hello World");
            }
        }
    }
}
