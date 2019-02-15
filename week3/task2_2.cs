using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete(@"C:\Users\Mukhtar\Desktop\new0\new"); //задаем путь и удаляем выбранный файл 

            Directory.Delete(@"C:\Users\Mukhtar\Desktop\new"); // задаем путь и удаляем выбранную папку но она должна быть пуста
        }
    }
}