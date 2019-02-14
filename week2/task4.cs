using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "MyText.txt"; // имя файла который я хочу создать
            string PathString = @"C:\Users\Mukhtar\Desktop\PP2\PP2\week2"; // и где я его хочу создать

            PathString = Path.Combine(PathString, fileName); // нужно скомбинировать их пути
            FileStream fs = File.Create(PathString); // и создаем
            fs.Close(); // нужно что бы прекратил работу

            string PathString2 = @"C:\Users\Mukhtar\Desktop\PP2\PP2"; // путь куда я должен я скопировать

            string destFile = Path.Combine(PathString2, fileName); // скомбинируем путь
            File.Copy(PathString, destFile); // копируем туда

            File.Delete(PathString); // и удаляем оригинал


        }
    }
}