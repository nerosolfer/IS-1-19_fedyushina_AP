using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnectDB;

namespace IS_1_19_fedyushinaAP
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB1 ConnDb1 = new ConnectDB1();
            MySqlConnection connDb = new MySqlConnection(ConnDb1.Initialization1());
            string fio_stud = textBox1.Text;
            string datetime = textBox2.Text;

            string datetime_stud = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            MessageBox.Show(datetime_stud);
            string zapr = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{fio_stud}','{datetime}');";
            int x = 0;
            try
            {
                connDb.Open();

                MySqlCommand com1 = new MySqlCommand(zapr, connDb);
                x = com1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //это я украл, потому что непонятно
                string message = ex.Message;
                MessageBox.Show(message);
                this.Close();
            }
            finally
            {
                connDb.Close();

                if (x != 0)
                {
                    MessageBox.Show("Успешно!");
                }
            }
        }
    }
}
