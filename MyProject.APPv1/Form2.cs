﻿using Myprojec.MODEL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyProject.APPv1
{
    public partial class Form2 : Form
    {
        Thread nt;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto(1, textBox1.Text, textBox2.Text, dateTimePicker1.Value, dateTimePicker2.Value, textBox6.Text, 0);
            ProjetoRepository.Add(projeto);
            //  MessageBox.Show(Convert.ToString(projeto.DatainiciodoProjeto));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(Formnovo4);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Formnovo4()
        {
            Application.Run(new Form4());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}