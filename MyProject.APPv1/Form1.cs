using Myprojec.MODEL;

namespace MyProject.APPv1
{
    public partial class Form1 : Form
    {

        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
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
    }
}