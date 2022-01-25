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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }
        //object sender gönderici olayı başlatan
        private void rakam_tiklama(object sender, EventArgs e)
        {       //hangi nesneyle geldi kim yolladı
            textBox1.Text += ((Button)sender).Text;
        }

        private void islem_tiklama(object sender, EventArgs e)
        {
            label1.Text = ((Button)sender).Text;
            label3.Text = textBox1.Text;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (label1.Text)
            {
                case "+": textBox1.Text = (Convert.ToDouble(label3.Text) + Convert.ToDouble(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (Convert.ToDouble(label3.Text) - Convert.ToDouble(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (Convert.ToDouble(label3.Text) * Convert.ToDouble(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (Convert.ToDouble(label3.Text) / Convert.ToDouble(textBox1.Text)).ToString(); break;
                default: break;
            }
        }

            private void c_tiklama(object sender,EventArgs e) {
            textBox1.Text = "";
            label1.Text = "";
            label3.Text = "";
            
            }
        private void virgul_tiklama(object sender, EventArgs e) {
            textBox1.Text += ".";
        }
        Form2 form2;
        private void button18_Click(object sender, EventArgs e)
        {

            
           // Form2 form2 = new Form2();
            if(form2==null||form2.IsDisposed)
            { form2 = new Form2(); }
            else { form2.Activate(); }
            form2.Show();
            this.Hide();
        }


    }
    
}
