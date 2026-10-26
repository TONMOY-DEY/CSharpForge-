using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Variable
    {
        public Variable()
        {
            string name = "Jhon";
            Console.WriteLine(name);

            int mynum;
            mynum = 25;
            Console.WriteLine(mynum);

            int num = 25;
            num = 365;
            Console.WriteLine(num);
            Console.WriteLine("............................................");

            int num1 = 5;
            double mydoublenum23 = 5099D;
            char myLetter = 'D';
            bool myBool = false;
            string mytext = "Hello bro";

            Console.WriteLine(num1);
            Console.WriteLine(mydoublenum23);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(mytext);



            //Constants
            //This is a unique keyword because 2nd time variable not change
            //Declares a variable that is read-only and unchangeable.
            const int mynum56 = 554;
            //mynum56 = 569;


            string name65 = "keru";
            Console.WriteLine("Hello..........." + name65);


            //display
            string name89 = "Tonmoy";
            string name56 = "Dey";

            string fullname = name89 + name56;
            Console.WriteLine(fullname);


            //Display sum
            int x1 = 58;
            int x23 = 56;

            Console.WriteLine(x1 + x23);


            //Multiple variable 

            int x25, x58, x78;
            x25 = x58 = x78 = 58;
            Console.WriteLine(x25 + x58 + x78);

            long myNum = 15000000000L;
            Console.WriteLine(myNum);

            float mynum568 = 5.6589F;
            Console.WriteLine(mynum568);

            double number87 = 5.365D;
            Console.WriteLine(number87);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);


            bool csharpfun = true;
            bool csharpfun5 = false;
            Console.WriteLine(csharpfun);
            Console.WriteLine(csharpfun5);

            //Type casting 
            //Implicit 
            int number = 58;
            double number58 = number;
            Console.WriteLine(number58);

            //Explecit 

            double p = 58.5648D;
            int q = (int)p;
            Console.WriteLine(q);

            double mydouble = 5987.659886D;
            int z = (int)mydouble;
            Console.WriteLine(z);


            //Type Conversion Methods
            int a = 58;
            double t = 589.235D;
            float v = 5897.23f;

            Console.WriteLine(Convert.ToString(a));
            Console.WriteLine(Convert.ToInt32(t));
            Console.WriteLine(Convert.ToInt16(v));

            //User input

            //Console.WriteLine("please enter the use name:");
            //String username=Console.ReadLine();
            //Console.WriteLine("username:"+username);

            //Console.WriteLine("Please enter the full name:");
            //String username58=Console.ReadLine();
            //Console.WriteLine("Full name:" + username58);

            Console.WriteLine("Enter in your age:");
            int age568 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is :" + age568);

            Console.WriteLine("Enter in your id");
            String id = Console.ReadLine();
            Console.WriteLine("id is :" + id);

            //sum
            Console.WriteLine("Please enter the number1:");
            int m = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the number2:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum is:");
            int sum = m + m;
            Console.WriteLine(sum);

            sum++;
            Console.WriteLine("Increment sum is :" + sum);

            Console.WriteLine("Modulus is:");
            int mosulus = m % n;
            Console.WriteLine(mosulus);

            //Assignment Operator
            int x = 5;
            x = x + 3;
            Console.WriteLine(x);

            int y = 5;
            y *= 3;
            Console.WriteLine(y);

            int g = 5;
            g &= 3;
            Console.WriteLine(g);

            int a56 = 5;
            int b25 = a56 + 2;
            bool test = false;
            //int c58 = a56 + test;
            Console.WriteLine(b25);

            byte[] number56 = { 1, 2, 3, 4, 5, 6, 7 };
            byte[] tonmoy25 = number56;
            tonmoy25[0] = 25;
            //Console.WriteLine(Convert.ToInt32(number56));

            double t54 = 56.25;
            int h = (int)t54;
            Console.WriteLine(h);


            object obj = 42;
            int nnnumber = (int)obj;
            Console.WriteLine(nnnumber);

            object obj1 = "Hello";
            bool result = obj1 is string;
            Console.WriteLine(result);

            object obj2 = "Hello";
            object result25 = obj2 as string;
            Console.WriteLine(result25);

            object obj3 = "Hello";
            Console.WriteLine(obj3 is string);

            object obj4 = 123;
            string text = obj4 as string;
            //Console.WriteLine(text);
            Console.WriteLine(text == null);


            string name6006 = "Tonmoy";
            string name5878 = "Dey";

            string resulttttt = name6006 + " -- " + name5878;
            Console.WriteLine(resulttttt);

        }

        

        
                






















    }

        }

    





