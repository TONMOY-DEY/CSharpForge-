using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Person
    {
        public  string name;
        public int age;
        public string id;


        public Person(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public void displayinfo()
        {
            Console.WriteLine("Person information");
            Console.WriteLine("person name is:" + this.name);
            Console.WriteLine("Person age is :" + this.age);
            Console.WriteLine("person id is :"+this.id);
        }
    }
}
