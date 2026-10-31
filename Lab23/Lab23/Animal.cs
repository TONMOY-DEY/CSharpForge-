using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Animal
    {
        public String name;
        public String animal_food;
        public void Eat()
        {
            Console.WriteLine("please write the animal food ");
            animal_food=Console.ReadLine();
            Console.WriteLine("This is animal food" + animal_food);
        }

        public void bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
