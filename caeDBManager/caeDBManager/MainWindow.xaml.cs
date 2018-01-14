using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using CefSharp;
using MySql.Data.MySqlClient;
using MessageBox = System.Windows.Forms.MessageBox;

namespace caeDBManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IBrowser
    {
        // Chromium Embedded Framework
        static IBrowser xd;
        public CefSharp.WinForms.ChromiumWebBrowser browser = (CefSharp.WinForms.ChromiumWebBrowser)xd;
        // SQL Connection
        private MySqlConnection mcon;
        MySqlCommand mcd;
        MySqlDataReader mdr;
        private String action;

        public bool CanGoBack => CanGoBack;

        public bool CanGoForward => throw new NotImplementedException();

        public bool IsLoading => throw new NotImplementedException();

        public int Identifier => throw new NotImplementedException();

        public bool IsPopup => throw new NotImplementedException();

        public bool HasDocument => throw new NotImplementedException();

        public IFrame MainFrame => throw new NotImplementedException();

        public IFrame FocusedFrame => throw new NotImplementedException();

        public bool IsDisposed => throw new NotImplementedException();

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
            browser_Stack.Children.Add(host);
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

        private void homebbtn_Click(object sender, RoutedEventArgs e)
        {
            // Start Chromium
            System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
            browser = new CefSharp.WinForms.ChromiumWebBrowser(App.url)
            {
                Dock = DockStyle.Fill,
                Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height),
                Location = new System.Drawing.Point(0, 0),

            };
            // This allows Chromium (CEF) to handle downloads
            browser.DownloadHandler = new DownloadHandler();
            // Assign the MaskedTextBox control as the host control's child.
            host.Child = browser;
            browser_Stack.Children.Clear();
            // Add the interop host control to the Grid
            // control's collection of child controls.
            browser_Stack.Children.Add(host);
        }

        private void backbttn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GoBack();
            }
            catch { }
        }

        private void refreshbttn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Reload();
            }
            catch { }
        }

        public IBrowserHost GetHost()
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            browser.Back();
        }

        public void GoForward()
        {
            browser.Forward();
        }

        public void CloseBrowser(bool forceClose)
        {
            throw new NotImplementedException();
        }

        public void Reload(bool ignoreCache = false)
        {
            browser.Reload();
        }

        public void StopLoad()
        {
            throw new NotImplementedException();
        }

        public bool IsSame(IBrowser that)
        {
            throw new NotImplementedException();
        }

        public IFrame GetFrame(long identifier)
        {
            throw new NotImplementedException();
        }

        public IFrame GetFrame(string name)
        {
            throw new NotImplementedException();
        }

        public int GetFrameCount()
        {
            throw new NotImplementedException();
        }

        public List<long> GetFrameIdentifiers()
        {
            throw new NotImplementedException();
        }

        public List<string> GetFrameNames()
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~MainWindow() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion

        private void forwardbttn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GoForward();
            }
            catch { }
        }
    }
}
