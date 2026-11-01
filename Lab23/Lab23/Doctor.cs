using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Doctor:Person
    {
        public string specialization;
        public double salary;
        public MedicaleLicense number;

        public Doctor(string specialization,double salary,string
         name,int age,string id,string Licensenumber,string issudate) :base(name,age,id)
        {
            this.specialization = specialization;
            this.salary = salary;
            number = new MedicaleLicense(Licensenumber, issudate);
        }

        public void displayDoctorinfo()
        {
            Console.WriteLine("Doctor information");

            Console.WriteLine("Specialization  sector is:" + this.specialization);
            Console.WriteLine("Salary is:" +this. salary);
            displayinfo();
            number.Display();


        }



    }
}
