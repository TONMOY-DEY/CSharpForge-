using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class MedicaleLicense
    {
        public string Licensenumber;
        public string issudate;

        public MedicaleLicense(string Licensenumber,string issudate) {
            this.Licensenumber = Licensenumber;
            this.issudate = issudate;
        }

        public void Display()
        {
            Console.WriteLine("Legal information");
            Console.WriteLine("Licensenumber is:"+this.Licensenumber);
            Console.WriteLine("Issudate is:" + this.issudate);
        }
    }
}
