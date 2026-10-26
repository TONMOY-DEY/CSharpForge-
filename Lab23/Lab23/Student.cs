using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Student
    {
        public string name;
        public int age;
    
 public void study()
        {
            Console.WriteLine("Student is studying");
            Console.WriteLine("Student name is:" + name);
            Console.WriteLine("Student age is:" + age);
        }
    }
}