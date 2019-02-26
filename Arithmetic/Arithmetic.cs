using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmeticns
{
    public class Arithmetic
    {
        public static int Add (int op1, int op2)
        {
            if(op1 < -50 ||  op1> 50)
            {
                throw new Exception("Out of range");
            }
            if(op2 < -50 || op2 > 50)
            {
                throw new Exception("Out of range");
            }
            return op1 + op2;
        }
        public static int Subtract (int op1, int op2)
        {
            if (op1 < -50 || op1 > 50)
            {
                throw new Exception("Out of range");
            }
            if (op2 < -50 || op2 > 50)
            {
                throw new Exception("Out of range");
            }
            return op1 - op2;
        }
        public static int Multiply(int op1, int op2)
        {
            if (op1 < -50 || op1 > 50)
            {
                throw new Exception("Out of range");
            }
            if (op2 < -50 || op2 > 50)
            {
                throw new Exception("Out of range");
            }
            return op1 * op2;
        }
        public static int Divide(int op1, int op2)
        {
            if(op2 == 0)
            {
                throw new DivideByZeroException("Invalid Operator");
            }
            if (op1 < -50 || op1 > 50)
            {
                throw new Exception("Out of range");
            }
            if (op2 < -50 || op2 > 50)
            {
                throw new Exception("Out of range");
            }
            return op1 / op2;
            
        }



        public static int sqr ( int nbr)
        {
            if (nbr <10 || nbr > 100)
            {
                throw new Exception("Out of Range!");
            }
            return nbr * nbr;
        }
    }
}
