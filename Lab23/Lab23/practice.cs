using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class practice
    {
        public practice()
        {
            Console.WriteLine("pleae enter the number:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());



            int sum = a + b;
            Console.WriteLine("sum is :"+sum);

            int Difference = a - b;
            Console.WriteLine("Difference is :"+Difference);

            int Multiplication = a * b;
            Console.WriteLine("Multiplecation is:"+Multiplication);

            int Division = a / b;
            Console.WriteLine("Division is :"+Division);

            int Remainder = a * b;
            Console.WriteLine("Reminder is:" + Remainder);
        }
    }
}
