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
            //Generic Method
            FindMaxGenericMethod<int>.FindMaxValue(11, 23, 30);       
            FindMaxGenericMethod<float>.FindMaxValue(20.45f, 30.11f, 12.99f);       
            FindMaxGenericMethod<string>.FindMaxValue("abc", "def", "ghi");       
            //find max using generic class .
            new FindMaxGenericClass<int>(20, 30, 12).TestMaximum();                   
            new FindMaxGenericClass<float>(20.45f, 30.11f, 12.99f).TestMaximum();
            new FindMaxGenericClass<string>("abc", "def", "ghi").TestMaximum();
            Console.ReadLine();
        }
    }
}
