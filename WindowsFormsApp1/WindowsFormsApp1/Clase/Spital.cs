using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clase
{
    public class Spital
    {
        private int cod;

        public List<Doctor> doctors;

        public Spital(List<Doctor> doctors)
        {
            this.doctors = doctors;
        }

        public Spital() {
            cod = 0;
            doctors = new List<Doctor>();
        }

       

        public Spital(int cod)
        {
            this.cod = cod;
            doctors = new List<Doctor>();
        }

        public override string ToString()
        {
            return "Spitalul are codul: "+ cod;
        }
        //------------------------------------------------------

    }


}
