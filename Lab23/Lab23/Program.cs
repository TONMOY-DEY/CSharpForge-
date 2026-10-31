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
            Student s1 = new Student();
            s1.name = "Tonmoy";
            s1.age = 21;
            s1.study();

           Teacher12 t1=new Teacher12();
            Teacher12 t2=new Teacher12("Akib",12,25653.00);

            int[] number = {1,2,3,4,5,6,7};
            int lengthofnumber = number.Length;
            Console.WriteLine(lengthofnumber);

            Jagged j1= new Jagged();
            j1.Run();


            Cat c1=new Cat();
            c1.Eat();
            //c1.name = "Caw";
            //Console.WriteLine(c1.name);
            c1.Eattttt();
            //c1.name = "tommy";
            //Console.WriteLine(c1.name);
            //c1.Description = "Tommy is a good animal";
            //Console.WriteLine(c1.Description);
         














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


