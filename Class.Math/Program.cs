using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Math
{
    public class Math
    {
        //Addition of two int elements
        public int Add (int x, int y)
        {
            return x + y;   
        } 
        //Subsctraction of two int elements
        public int Sub (int x, int y)
        {
            return x - y;
        }
        //Division of two int elements
        public int Div (int x, int y)
        {
            return x / y;
        }
        //Multiply two int elements
        public int Mult (int x, int y)
        {
            return x * y;   
        }
        //Finding max value out of two passed parameter x , y
        public int Max (int x, int y)
        {
            return x > y ? x : y; 
        }
        //Finding min value out of two passed parameter x , y
        public int Min (int x, int y)
        {
            return x < y ? x : y;
        }


        //public int random (int x, int y)
        //{
        //    int[] array = new int[y];

        //    for(int i = x; i <= y; i++)
        //    {
        //        array[i] = i;
        //    }

        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {


            int x = 3;
            int y = 12;

            int Arraylength (int i, int j)
            {
                if(i > j)
                {
                    return i - j;
                }
                else
                {
                    return j - i;
                }
            }

            Console.WriteLine(Arraylength(10, 15));

            int[] arr = new int[Arraylength(x, y)];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"before : {arr[i]}");
            }

            for (int i = x; i < y; i++)
            {
                arr[i] = i;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"after : {arr[i]}");
            }

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            Console.ReadLine();
        }
    }
}
