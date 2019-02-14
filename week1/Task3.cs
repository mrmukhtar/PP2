using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); // первый элемент считал и перевел в int
            string s = Console.ReadLine();
            string[] a = s.Split(); // поделил строки через пробел и залил в массив

            string[] b = new string[x * 2];
            //0 1 2
            //1 2 3
            //1 1   2 2   3 3
            //0 1   2 3   4 5
            for(int i=0; i<x; i++)
            {
                b[i * 2] = a[i];
                b[i * 2 + 1] = a[i];
            }
            for (int i = 0; i < x*2; i++)
            {
                Console.Write(b[i]);
            }
    }
}