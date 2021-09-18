using System;
using System.Collections.Generic;

namespace MyIVProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>() { 1,2,3,4,5,6,7,8,9,10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine("Imprimiendo Valores Pares ");
            Console.WriteLine("=========================");

            foreach (int i in Lista.Pares())
            {
                Console.WriteLine("Para : "+ i.ToString());
            }


            Console.WriteLine("Imprimiendo Valores Imares ");
            Console.WriteLine("=========================");

            foreach (int i in Lista.Impares())
            {
                Console.WriteLine("Para : " + i.ToString());
            }

        }
    }
}
