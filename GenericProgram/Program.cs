using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Use Case Programs ");
            //UC1 finding max out of 3 int.
            FindMaximum.FindMaxValue(10, 20, 30);
            //UC2 finding max out of 3 float.
            FindMaximum.FindMaxValue(20.20f, 30.20f, 40.40f);
            //UC3 finding max out of 3 string.
            FindMaximum.FindMaxValue("abc", "def", "opq");
        }
    }
}
