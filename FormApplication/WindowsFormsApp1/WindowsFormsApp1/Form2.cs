using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {/*
            Form1 form1 = new Form1();
            form1.Show();
            */
            Application.OpenForms["Form1"].Show();
        }

        int saat = 0;
        int saniye = 0;
        int dakika = 0;
        private void button3_Click(object sender, EventArgs e)
        {
         saat = 0;
         saniye = 0;
         dakika = 0;
 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            label6.Text = "%" + progressBar1.Value;


            label3.Text = saniye.ToString();
            label2.Text = dakika.ToString();
            label1.Text = saat.ToString();
            saniye++;
            if (saniye == 60) { dakika++; saniye = 0; }
            if (dakika == 60) { saat++; dakika = 0; }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e) {
            timer1.Stop();
        }

     

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
