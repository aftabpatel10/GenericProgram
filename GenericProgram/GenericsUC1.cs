using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProgram
{
    public class FindMaximum
    {
        //UC1 finding maximum value of 3 numbers.
        public static void FindMaxValue(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine($"{first} is greater");
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine($"{second} is greater");
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine($"{third} is greater ");
            }
            else
                Console.WriteLine("All Numbers are Equal! ");
        }
        //UC2 finding maximum value out of 3 float.
        public static void FindMaxValue(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine($"{first} is greater");
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine($"{second} is greater");
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine($"{third} is greater ");
            }
            else
                Console.WriteLine("All Numbers are Equal! ");
        }
        //UC2 finding maximum value out of 3 string.
        public static void FindMaxValue(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine($"{first} is greater");
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine($"{second} is greater");
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine($"{third} is greater ");
            }
            else
                Console.WriteLine("All Numbers are Equal! ");
        }
    }
}