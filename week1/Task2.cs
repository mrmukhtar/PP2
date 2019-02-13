using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mukhtar", "18BD110959", 1);
            s1.September();
        }
    }
    class Student
    {
        string Name { set; get; }
        string ID { set; get; }
        int YoS { set; get; }
        public Student(string Name, string ID, int YoS)
        {
            this.Name = Name;
            this.ID = ID;
            this.YoS = YoS;
        }
        public void September()
        {

            Console.WriteLine("Student: {0}, ID: {1}, Year of study: {2}", Name, ID, YoS);


            Console.ReadKey();
        }


    }
}