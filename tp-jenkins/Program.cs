using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: CLSCompliant(true)]
namespace tpJenkins
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello world");
           // Console.WriteLine("15 + 16 = "+Add(15,16));
            Console.ReadLine();
        }


        public static int  Add(int a, int b)
        {
            return a + b;
        }

        public static  int Division (int a, int b)
        {
            return a / b;
        }
    }
}
