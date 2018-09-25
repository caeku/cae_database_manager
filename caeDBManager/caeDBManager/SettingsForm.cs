using System;
using System.Windows.Forms;

namespace caeDBManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                genderListBox.SelectedIndex = Int32.Parse(Properties.Settings.Default["VoiceGender"].ToString());
                mutecheckBox.Checked = (bool)Properties.Settings.Default["Mute"];
                URLTextbox.Text = Properties.Settings.Default["DefaultURL"].ToString();
            }
            catch { }
        }

        private void mutecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["Mute"] = mutecheckBox.Checked;
        }

        private void genderListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default["VoiceGender"] = genderListBox.SelectedIndex;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["DefaultURL"] = URLTextbox.Text;
            Properties.Settings.Default.Save();
        }

        private void URLTextbox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["DefaultURL"] = URLTextbox.Text;
        }
    }
}
