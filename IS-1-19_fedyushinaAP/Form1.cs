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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Kompl<J>
        {
            public J _art;
            public int _price;
            public int _year;

            public Kompl(J art, int price, int year)
            {
                _art = art;
                _price = price;
                _year = year;      
            }

            public abstract void Display(ListBox lb);
        }
        class CP<J> : Kompl<J>
        {
            private float gz;
            public float _gz
            {
                get { return gz; }
                set { gz = value; }
            }
            private int core;
            public int _core
            {
                get { return core; }
                set { core = value; }
            }
            private int potok;
            public int _potok
            {
                get { return potok; }
                set { potok = value; }
            }
            public CP(J art, int price, int year, float gz, int core, int potok)
            : base(art, price, year)
            {
                _gz = gz;
                _core = core;
                _potok = potok;
            }
            public override void Display(ListBox lb)
            {
                lb.Items.Add($"Артикул товара : {_art}");
                lb.Items.Add($"Цена товара : {_price}");
                lb.Items.Add($"Год выпуска товара : {_year}");
                lb.Items.Add($"Тактовая частота процессора :{_gz}");
                lb.Items.Add($"Количество ядер процессора :{_core}");
                lb.Items.Add($"Количество потоков процессора :{_potok}");
            }
        }

        class Video<J> : Kompl<J>
        {
            private string chast;
            public string _chast
            {
                get { return chast; }
                set { chast = value; }
            }

            private string proizv;
            public string _proizv
            {
                get { return proizv; }
                set { proizv = value; }
            }

            private int mem;
            public int _mem
            {
                get { return mem; }
                set { mem = value; }
            }

            public Video( J art, int price, int year, string gpu, string proiz, int gb)
            : base(art, price, year)
            {
                _chast = gpu;
                _proizv = proiz;
                _mem = gb;
            }
            public override void Display(ListBox lb)
            {
                lb.Items.Add($"Артикул товара : {_art}");
                lb.Items.Add($"Цена товара : {_price}");
                lb.Items.Add($"Год выпуска товара : {_year}");
                lb.Items.Add($"Частота видеочипа :{_chast}");
                lb.Items.Add($"Фирма производитель :{_proizv}");
                lb.Items.Add($"Объём памяти :{_mem}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CP<string> cp = new CP<string>(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            cp.Display(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Video<string> vid = new Video<string>(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox7.Text, textBox8.Text, Convert.ToInt32(textBox9.Text));
            vid.Display(listBox1);
        }
    }
}
