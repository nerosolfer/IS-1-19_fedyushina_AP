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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            ConnectDB1 ConnDb1 = new ConnectDB1();
            MySqlConnection connDb = new MySqlConnection(ConnDb1.Initialization1());
            string zapros = "SELECT idStud, fioStud, drStud FROM t_datetime";
            try
            {
                connDb.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(zapros, connDb);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                this.Close();
            }
            finally
            {
                connDb.Close();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;

                string index1;
                string id1 = "0";

                index1 = dataGridView1.SelectedCells[0].RowIndex.ToString();
                id1 = dataGridView1.Rows[Convert.ToInt32(index1)].Cells[1].Value.ToString();
                DateTime x = DateTime.Today;
                DateTime y = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(index1)].Cells[2].Value.ToString());
                string result = (x - y).ToString();
                MessageBox.Show("Со дня рождения прошло " + result.Substring(0, result.Length - 9) + " дня(-ей)");
            }

         
        }
    }
}

