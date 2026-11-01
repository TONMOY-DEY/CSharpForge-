using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Nurse:Person
    {
        public string shift;
        public double Salary;

        public Nurse(string shift, double Salary,string name,int age,string id) : base(name, age, id)
        {
            this.shift = shift;
            this.Salary = Salary;
        }

        public void Displaynurseinfo()
        {
            Console.WriteLine("Nurse information");
            Console.WriteLine("Shift time is:" + this.shift);
            Console.WriteLine("Salary is:" + this.Salary);
            displayinfo();
        }
    }

    
}
