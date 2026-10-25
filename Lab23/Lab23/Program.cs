using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
  
        

            enum Traficstatus
        {
            pending,
            passed,
            failed
        }
        static void Main(string[] args)
        { 
            Traficstatus T1= Traficstatus.pending;
            Console.WriteLine(T1);
            Console.WriteLine((int )T1);

        //practice s1 = new practice();
         Variable V1=new Variable();
            dog d1=new dog();
            d1.name585 = "Tommy";
            d1.bark();



        //Method obj = new Method();
        //int result = obj.Add(10, 20);

        //Console.WriteLine(result);
    }
    }
}
