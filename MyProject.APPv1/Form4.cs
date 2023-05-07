using Myprojec.MODEL;
using MyProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.APPv1
{
    public partial class Form4 : Form
    {
        Thread nt;
        public Form4()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            nt = new Thread(Formnovo2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Formnovo2()
        {
            Application.Run(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            nt = new Thread(Formnovo3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Formnovo3()
        {
            Application.Run(new Form3());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Projeto> List1 = ProjetoRepository.getAll();
            dataGridView1.DataSource = List1;
        }


    }
}
