using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Cat:Animal
    {
        
        public string Description;
        public string eat;


        public void Eattttt()
        {
            this.name = "caw";
            Console.WriteLine(this.name);
            Console.WriteLine("cat mawww");
        }

    }
}
