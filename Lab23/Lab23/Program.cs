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
            Traficstatus T1 = Traficstatus.pending;
            Console.WriteLine(T1);
            Console.WriteLine((int)T1);

            servingsizes s = servingsizes.samall;
            Console.WriteLine(s);
            

            //practice s1 = new practice();
            Variable V1 = new Variable();
            Variable V2 = V1;
            Variable V3 = (Variable)V2;
            dog d1 = new dog();
            d1.name585 = "Tommy";
            d1.bark();

            point.point1 p1 = new point.point1();
            p1.x = 10;
            p1.y = 20;

            Console.WriteLine(p1.x);
            Student s1= new Student();
            s1.student();
        }

            enum servingsizes : int
        {
            samall=1,
            Regular=2,
            Large=3
        }

        



           
 
            





            //Method obj = new Method();
            //int result = obj.Add(10, 20);

            //Console.WriteLine(result);
        }
    }


