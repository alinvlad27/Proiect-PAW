using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
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

        private void DisplayDoctors()
        {
            treeView1.Nodes[0].Nodes.Clear();
            spital.doctors.Sort();
            foreach (var doctor in spital.doctors)
            {
                TreeNode node = new TreeNode(doctor.ToString());
                node.Tag = doctor;
                treeView1.Nodes[0].Nodes.Add(node);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            spital = new Spital(1);
            TreeNode treeNode = new TreeNode(spital.ToString());
            treeView1.Nodes.Add(treeNode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = File.OpenWrite("export.bin"))
            {
                bf.Serialize(fs, spital);
            }
        }

        private void deserealizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("export.bin"))
            {
                spital = (Spital)bf.Deserialize(fs);
                DisplayDoctors();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
