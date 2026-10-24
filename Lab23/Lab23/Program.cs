using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //practice s1 = new practice();
            //Variable V1=new Variable();
            Method obj = new Method();
            int result = obj.Add(10, 20);

            Console.WriteLine(result);
        }
    }
}
