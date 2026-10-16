using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Variable
    {
        public Variable(){
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
            bool myBool= false;
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
            Console.WriteLine("Hello..........."+name65);


            //display
            string name89 = "Tonmoy";
            string name56 = "Dey";

            string fullname = name89 + name56;
            Console.WriteLine(fullname);


            //Display sum
            int x1 = 58;
            int x23 = 56;

            Console.WriteLine(x1+x23);


            //Multiple variable 

            int x25,x58,x78;
            x25 = x58 = x78 = 58;
            Console.WriteLine(x25+x58+x78);

            long myNum = 15000000000L;
            Console.WriteLine(myNum);

            float mynum568 = 5.6589F;
            Console.WriteLine(mynum568);

            





        }

    }
}



