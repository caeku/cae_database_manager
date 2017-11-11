using System;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MessageBox = System.Windows.Forms.MessageBox;

namespace caeDBManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Chromium Embedded Framework
        public CefSharp.WinForms.ChromiumWebBrowser browser;
        // SQL Connection
        private MySqlConnection mcon;
        MySqlCommand mcd;
        MySqlDataReader mdr;
        private String action;
        public MainWindow()
        {
            InitializeComponent();
        }

        // Show AddTutor Form
        private void AddBttn_OnClick(object sender, RoutedEventArgs e)
        {
            AddTutor form = new AddTutor();
            form.Show();
        }

        // Show SeeAll Form
        private void SeeAllBttn_OnClick(object sender, RoutedEventArgs e)
        {
            SeeTutors form = new SeeTutors();
            form.Show();
        }

        // Show DeleteTutor Form
        private void DeleteBttn_Click(object sender, RoutedEventArgs e)
        {
            DeleteTutor form = new DeleteTutor();
            form.Show();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            // Start Chromium
            System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
            browser = new CefSharp.WinForms.ChromiumWebBrowser(App.url)
            {
                Dock = DockStyle.Fill,
                Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height),
                Location = new System.Drawing.Point(0,0),

            };
            // This allows Chromium (CEF) to handle downloads
            browser.DownloadHandler=new DownloadHandler();
            // Assign the MaskedTextBox control as the host control's child.
            host.Child = browser;

            // Add the interop host control to the Grid
            // control's collection of child controls.
            cae_tutor.Children.Add(host);
        }

        // Hide Advanced Options and Show the main windows
        private void MainWindows_Click(object sender, RoutedEventArgs e)
        {
            advanced_options.Visibility = Visibility.Collapsed;
            cae_tutor.Visibility = Visibility.Visible;
        }

        // Validate Password
        private void inputBox_Validating(object a, InputBoxValidatingArgs e)
        {
            try
            {
                if (e.Text.Trim().Length == 0)
                {
                    e.Cancel = true;
                    e.Message = "Required";
                }
                else
                {
                    mcon = new MySqlConnection(App.connectionString);
                    mcon.Open();
                    action = "select * from " + App.admin_table + " where id='" + e.Text + "';";
                    mcd = new MySqlCommand(action, mcon);
                    mdr = mcd.ExecuteReader();
                    if (mdr.Read())
                    {
                        // Hide Browser and Show Advanced Options
                        advanced_options.Visibility = Visibility.Visible;
                        cae_tutor.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        e.Cancel = true;
                        e.Message = "Wrong password";
                    }
                    mcon.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Something went wrong with the authentication. \n" + ex.ToString());
                mcon.Close();
            }
        }

        private void Advanced_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InputBoxResult result = InputBox.Show("Password","CAE DATABASE MANAGER", "", new InputBoxValidatingHandler(inputBox_Validating));
                if (result.OK)
                {
                    
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                throw;
            }

            
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            var confirmResult =
                MessageBox.Show("Should the need arise, the source code of this program can be downloaded from https://github.com/caeku/cae_database_manager" + "\nDo you want to download it?",
                    "About", MessageBoxButtons.YesNo);
            if (confirmResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/caeku/cae_database_manager");
            }
        }
    }
}
