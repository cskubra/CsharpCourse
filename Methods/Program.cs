using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Add();
            Add();
            Add();
            var result = Add2(20, 30);
            Console.WriteLine(result);
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(1,2,3,4,5,6));

            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added!!! Dont repeat yourself!!!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
