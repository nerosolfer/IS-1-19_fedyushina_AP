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

namespace IS_1_19_fedyushinaAP
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
        static class MySql
        {
            public static string host = "caseum.ru";
            public static string port = "33333";
            public static string user_id = "test_user";
            public static string database = "db_test";
            public static string password = "test_pass";

            public static string sqlconn()
            {
                string conn = $"server={host};port={port};user={user_id};database={database};password={password}";
                return conn;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conec = new MySqlConnection(MySql.sqlconn());
            try
            {
                conec.Open();
                MessageBox.Show("YES");
            }
            catch
            {
                MessageBox.Show("FAIL");
                conec.Close();
            }
        }
        

    }
}

