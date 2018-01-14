using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace caeDBManager
{
    public partial class SeeTutors : Form
    {
        public SeeTutors()
        {
            InitializeComponent();
            try

            {
                // Show all the Tutors using a datagrid
                MySqlConnection mcon = new MySqlConnection(App.connectionString);
                string Query = "select * from " + App.workers_table + ";";
                mcon.Open();
                MySqlCommand mcd = new MySqlCommand(Query, mcon);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = mcd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SeeTutors_Load(object sender, EventArgs e)
        {

        }
    }
}
