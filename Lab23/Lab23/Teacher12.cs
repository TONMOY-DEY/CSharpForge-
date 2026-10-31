using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Teacher12
    {
        public string name;
        public int  age;
        public double salary;

        public Teacher12() {
            name = "N/A";
            age = 0;
            salary = 0.0;
        
        }

        public Teacher12(string name,int age,double salary)
        {
            this.name = name;
            this.age = age;
            this.salary =salary ;
            Console.WriteLine("Name is :" + name);
            Console.WriteLine("Age is:"+age);
            Console.WriteLine("Salary is :"+salary);

            Console.WriteLine("Teacher position is LEcture");
        }
    }
}
