using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        public string name;
        public int rno;
        public void displayDetails()
        {
            Console.WriteLine("Name = "+name);
            Console.WriteLine("Roll Number = " + rno);
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "Akthar";
            s1.rno = 1;
            s1.displayDetails();
            Student s2 = new Student();
            s2.name = "Amina";
            s2.rno = 2;
            s2.displayDetails();
            Console.Read();
        }
    }
}
