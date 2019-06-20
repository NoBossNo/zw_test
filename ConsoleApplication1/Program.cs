using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("dxper.net".Substring(3).Replace(".", "").ToUpper());

            Console.ReadKey();

        }
    }
}
