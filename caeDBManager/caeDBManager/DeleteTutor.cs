using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace caeDBManager
{
    public partial class DeleteTutor: Form
    {
        private MySqlConnection mcon;
        MySqlCommand mcd;
        MySqlDataReader mdr;
        private String action;

        public DeleteTutor()
        {
            try
            {
                mcon = new MySqlConnection(App.connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            InitializeComponent();
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            // ONly numbers can go...
            if (System.Text.RegularExpressions.Regex.IsMatch(IDtextBox.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                IDtextBox.Text = IDtextBox.Text.Remove(IDtextBox.Text.Length - 1);
            }
        }

        private void Resetbttn_Click(object sender, EventArgs e)
        {
            resetfields();
        }

        private void resetfields()
        {
            IDtextBox.Clear();
            firstNametextBox.Clear();
        }

        private async void DeleteBttn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                // If the fields are NOT empty...
                if ((!String.IsNullOrWhiteSpace(IDtextBox.Text)) && (!String.IsNullOrWhiteSpace(firstNametextBox.Text)))
                {
                    mcon.Open();
                    action = "select * from " + App.workers_table + " where id='" + IDtextBox.Text + "' && name='" + firstNametextBox.Text + "';";
                    mcd = new MySqlCommand(action, mcon);
                    mdr = mcd.ExecuteReader();
                    // If a record is found
                    if (mdr.Read())
                    {
                        var confirmResult =
                            MessageBox.Show(
                                "You will delete " + firstNametextBox.Text + " from the database. Are you sure? ",
                                "Deleting a Tutor", MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            mcon.Close();
                            // The sessions must also be deleted as both tables are related.
                            await Delete_sessions();
                            mcon.Open();
                            string Query = "delete from " + App.workers_table + " where id='" + IDtextBox.Text +
                                           "' && name='" + firstNametextBox.Text + "';";
                            MySqlCommand mcd3 = new MySqlCommand(Query, mcon);
                            mdr = mcd3.ExecuteReader();
                            MessageBox.Show("Tutor Deleted");
                            IDtextBox.Clear();
                            firstNametextBox.Clear();
                            while (mdr.Read())
                            {
                            }
                            mcon.Close();
                        }
                        else
                        {
                            mcon.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Tutor not found");
                        mcon.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Please complete the required information!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\n" + ex.ToString());
            }
        
    }

        private async Task Delete_sessions()
        {
            // Delete sessions
            try
            {
                mcon.Open();
                string Query = "delete from " + App.sessions_table + " where tutorid='" + IDtextBox.Text + "';";
                MySqlCommand mcd4 = new MySqlCommand(Query, mcon);
                mdr = mcd4.ExecuteReader();
                while (mdr.Read())
                {
                }
                mcon.Close();
                MessageBox.Show("Sessions deleted");
            }
            catch (Exception e)
            {
               mcon.Close();
                MessageBox.Show("Something went wrong with the sessions.\n" + e.ToString());
            }
          
        }
    }
}
