using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class problem2
    {
        public problem2()
        {
            Console.WriteLine("Plese enter the mark:");
            int mark=Convert.ToInt32(Console.ReadLine());

            //double percentage=Convert.ToDouble(Console.ReadLine());
            double percentage = ((double)mark / 500) * 100;
            Console.WriteLine("percentage:"+percentage);


            if (percentage >= 85)
            {
                Console.WriteLine("Grade = A");
            }

            else if (percentage >= 80) ;
            Console.WriteLine("Grade = B+");
        }
    }
}
