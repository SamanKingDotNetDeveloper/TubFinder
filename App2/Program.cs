using System;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            int[] a = new int[value];
            for(int i  = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++) 
            {
                /*  The simple form of IF  */ 
                Console.WriteLine(TubOrNo(a[i]) ? "Tub" : "Tubmas");
            }
            Console.ReadKey();
        }
        static bool TubOrNo(int n)
        {
            int k = 0;
            for (int i = 2; i < n; i++) 
            {
                if (n % i == 0) k++;
            }
            return k == 0;
        }
    }
}
