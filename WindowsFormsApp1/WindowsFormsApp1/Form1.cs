using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clase;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Spital spital;
        public Form1()
        {
            InitializeComponent();

            Doctor doctor1 = new Doctor { ID = 20, Name = "John Smith", Age = 10 };
            Doctor doctor2 = new Doctor { ID = 34, Name = "Mary Johnson", Age = 5 };
            List<Doctor> doctors = new List<Doctor> { doctor1, doctor2 };
            spital = new Spital(doctors);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
