using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Seniordoctor : Doctor
    {
        public int experienceyears;

        public Seniordoctor(int experienceyears, string specialization, double salary,
            string name, int age, string id, string Licensenumber, string issudate) :
            base(specialization, salary, name, age, id, Licensenumber, issudate)
        {
            this.experienceyears = experienceyears;

        }
        public void displayseniordoctor()
        {
            Console.WriteLine("Seniordoctor information:");
            displayDoctorinfo();

        }
    }
}