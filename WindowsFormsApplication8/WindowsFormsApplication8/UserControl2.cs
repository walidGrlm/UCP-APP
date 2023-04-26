using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var textBox1 = this.textBox1.Text;
            var textBox2 = this.textBox2.Text;

            var parent = this.Parent as Form1;
            parent.InputOne = textBox1;
            parent.InputTwo = textBox2;
        }
    }
}
