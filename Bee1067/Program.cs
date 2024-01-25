using System;
using System.Globalization;

namespace bee1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, cont;
            cont = 0;
            x = int.Parse(Console.ReadLine());

            while (cont <= x)
            {
                if (cont % 2 != 0)
                {
                    Console.WriteLine(cont);
                }
                cont++;
            }
        }
    }
}