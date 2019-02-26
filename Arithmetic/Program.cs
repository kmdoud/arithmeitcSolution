using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arithmeticns;

namespace Arithmeticns1
{
    class Program
    {
        static void TestValid(int testId, int nbr, int expected)
        {
            try
            {
                var actual = Arithmetic.sqr(nbr);
                if (actual == expected)
                {
                    Console.WriteLine($"Test #{testId}:PASS");
                }
                else
                {
                    Console.WriteLine($"Test #{testId}: FAIL");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Test #{testId}: FAIL");
            }
        }
        static void TestInvalid(int testId, int nbr)
        {
            //Test -127
            try
            {
                var result = Arithmetic.sqr(nbr);
                Console.WriteLine($"Test #{testId}: FAIL");
            }
            catch (Exception)
            {
                Console.WriteLine($"Test #{testId}:PASS");
            }
        }
        static void Main(string[] args)
        {
            TestInvalid(1, -127);
            TestInvalid(2, 9);
            TestValid(3, 10, 100);
            TestValid(4, 11, 121);
            TestValid(5, 53, 2809);
            TestValid(6, 99, 9801);
            TestValid(7, 100, 10000);
            TestInvalid(8, 101);
            TestInvalid(9, 1347);

        }

    }
}

