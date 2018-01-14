using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace caeDBManager
{
    public partial class AddTutor: Form
    {
        private MySqlConnection mcon;
        MySqlCommand mcd;
        MySqlDataReader mdr;
        private String action;
        public AddTutor()
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

        private void Resetbttn_Click(object sender, EventArgs e)
        {
          resetfields();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(IDtextBox.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                IDtextBox.Text = IDtextBox.Text.Remove(IDtextBox.Text.Length - 1);
            }
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(IDtextBox.Text)) && (!String.IsNullOrWhiteSpace(firstNametextBox.Text)) &&
                (!String.IsNullOrWhiteSpace(lastNametextBox.Text)))
            {
                DialogResult dialogResult =
                    MessageBox.Show(
                        "You are about to add a new tutor. \nName: " + firstNametextBox.Text + " " +
                        lastNametextBox.Text + "\nID: " + IDtextBox.Text + "\nContinue?", "Adding New Tutor...",
                        MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    mcon.Open();
                    action = "select * from " + App.workers_table + " where id='" + Convert.ToInt32(IDtextBox.Text) + "'";
                    mcd = new MySqlCommand(action, mcon);
                    mdr = mcd.ExecuteReader();
                    if (mdr.Read())
                    {
                        MessageBox.Show("It seems someone already has that ID.");
                        mcon.Close();
                    }
                    else
                    {
                        mcon.Close();
                        try
                        {
                            mcon.Open();
                            string Query =
                                "insert into " + App.workers_table + "(id,name,last,class) values('" + IDtextBox.Text + "','" + firstNametextBox.Text + "','" + lastNametextBox.Text + "','" + classComboBox.Text +"');";
                            MySqlCommand mcd2 = new MySqlCommand(Query, mcon);
                            MySqlDataReader MyReader2;
                            MyReader2 = mcd2.ExecuteReader();
                            // Here our query will be executed and data saved into the database.
                            MessageBox.Show("Tutor Added!");
                            resetfields();
                            while (MyReader2.Read())
                            {
                            }
                            mcon.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong. :( \n" + ex.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please complete the required information!");
            }
        }

        private void resetfields()
        {
            IDtextBox.Clear();
            firstNametextBox.Clear();
            lastNametextBox.Clear();
            classComboBox.ResetText();
        }

        private void AddTutor_Load(object sender, EventArgs e)
        {

        }
    }
}
