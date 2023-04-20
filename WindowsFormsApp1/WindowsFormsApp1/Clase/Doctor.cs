using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clase
{
    public class Doctor
    {
        private int id;
        private string name;
        private int age;

        public Doctor()
        {
            id = 0;
            name = "asda";
            age = 0;
        }

        public Doctor(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        { 
            get { return name; } 
            set{name = value;} 
        }

        public int Age
        {
            get { return age; } 
            set { age = value; }
        }

        public override string ToString()
        {
            return "Id -ul " + this.id + " si numele" + this.name + " si varsta" + this.age;
        }
        //--------------------------------------------------------------------------------------

    }

    
}
