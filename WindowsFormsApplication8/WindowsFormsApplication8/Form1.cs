using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string InputOne
        {
            set
            {
                textBox1.Text = value;
            }

        }

        public string InputTwo
        {
            set
            {
                textBox2.Text = value;
            }
        }
               

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
