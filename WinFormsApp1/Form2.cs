using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Form f;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = new Form3();
            f.Show();
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new Form4();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = new Form5();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f = new Form6();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
