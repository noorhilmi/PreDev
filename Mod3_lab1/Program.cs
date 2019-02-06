using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"Calling Sum(20, 40) with two arguments, result is: {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling Sum(10, 50, 80) with three arguments, result is: {result3}");

            double dbResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum(20.5, 30.6) that takes doubles results in: {dbResult}");
        }

        //Sum() method that takes two intger arguments and sums them
        //The method returns no value
        //using static because main is static
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
            
        }

        //this method takes three intger arguments and sums them, then return a value 
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        //this method takes two doubles as arguments ans sum them.
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
