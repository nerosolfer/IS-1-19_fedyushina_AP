using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_19_fedyushinaAP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 _form1 = new Form1();
            _form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 _form2 = new Form2();
            _form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 _form4 = new Form4();
            _form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 _form5 = new Form5();
            _form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 _form6 = new Form6();
            _form6.ShowDialog();
        }
    }
}
