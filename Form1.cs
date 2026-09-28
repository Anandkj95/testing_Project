using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Testing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
            int a = 10;
            if(a<10)
            {
                MessageBox.Show("a is lesser");
            }
            int b=Convert.ToInt32(textBox1.Text);
            MessageBox.Show(b.ToString());
        }
    }
}
