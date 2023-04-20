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
    public partial class Form2 : Form
    {
        private Spital spital;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Intro id ul");
                ok = true;
            }
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Intro numele");
                ok = true;
            }
            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Introdu varsta");
                ok = true;
            }
            if (ok == false)
            {
                errorProvider1.Clear();
                int id = Convert.ToInt32(textBox1.Text);
                string nume = textBox2.Text;
                int age = Convert.ToInt32(textBox3.Text);
                Doctor d = new Doctor(id, nume, age);
            }
            this.Close();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
