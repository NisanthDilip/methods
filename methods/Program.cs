using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int result=mymethod();
            Console.WriteLine(result);
            
        }
        public static int mymethod()
        {
            Console.WriteLine("Enter A Value");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Value");
            int b = Convert.ToInt32(Console.ReadLine());
            return a + b;

        }


    }
}