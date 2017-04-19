using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]

namespace TpJenkins
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello world");

            Console.ReadLine();
        }
        public static int  Add(int a, int b)
        {
            return a + b;
        }
        public static  int Division(int a, int b)
        {
            return a / b;
        }
    }
}
