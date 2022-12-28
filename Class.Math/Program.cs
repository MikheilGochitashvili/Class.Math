using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Math
{
    public class Math
    {
        public int Sum (int x, int y)
        {
            return x + y;   
        } 

        public int Sub (int x, int y)
        {
            return x - y;
        }

        public int Div (int x, int y)
        {
            return x / y;
        }

        public int Mult (int x, int y)
        {
            return x * y;   
        }

        public int Max (int x, int y)
        {
            if(x > y)
            {
                return x;
            } 
            else
            {
                return y;
            }
        }

        public int Min (int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();


            int minmax = math.Min(5, 21);

            Console.WriteLine(minmax);
        }
    }
}
