using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Move(@"C:\Users\Mukhtar\Desktop\PP2\PP2\week3\meme.txt", @"C:\Users\Mukhtar\Desktop\PP2\PP2\week3\newnew.txt"); // переименовывать файл
        }
    }
}