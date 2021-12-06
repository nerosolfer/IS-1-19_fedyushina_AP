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
using static IS_1_19_fedyushinaAP.Program;

namespace IS_1_19_fedyushinaAP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;

                string index;
                string id = "0";

                index = dataGridView1.SelectedCells[0].RowIndex.ToString();
                id = dataGridView1.Rows[Convert.ToInt32(index)].Cells[1].Value.ToString();
                MessageBox.Show(id);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ConnectDB ConnDb = new ConnectDB();
            MySqlConnection connDb = new MySqlConnection(ConnDb.Initialization());
            string zapros = "SELECT id, fio, theme_kurs FROM t_stud";
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
    }
}
