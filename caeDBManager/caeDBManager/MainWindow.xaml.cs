using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Threading.Tasks;
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
        public string text = "Dummy text";
        public CefSharp.WinForms.ChromiumWebBrowser browser = (CefSharp.WinForms.ChromiumWebBrowser)xd;
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
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


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            const string message = "Are you sure that you would like to exit?";
            const string caption = "Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        [ComVisible(true)]
        public class FrameElementInterceptor
        {
            public void Intercept(string propKey, object[] args)
            {
                MessageBox.Show($@"Function '{propKey}' was called with arguments: [{string.Join(", ", args)}]",
        @"Function call intercepted");
            }
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

        [STAThread]
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            //    Xpcom.Initialize("Firefox");
            //    var geckoWebBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            //    Form f = new Form();
            //    f.Controls.Add(geckoWebBrowser);
            //    geckoWebBrowser.Navigate(App.url);
            //f.Show();

            speechSynthesizer.Volume = 100;
            speechSynthesizer.Speak("Welcome!");

            //Set sizes
            double height = SystemParameters.VirtualScreenHeight- TopPanel.Height - BrowserControl.Height - 72;
            browser_Stack.Height = height;
            // Start Chromium
            System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
            host.MaxHeight = browser_Stack.Height;

            CefSettings settings = new CefSettings();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settings.RemoteDebuggingPort = 8080;
            settings.CachePath = path;

            //For legacy biding we'll still have support for
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;

            //Initialize Cef with the provided settings
            Cef.Initialize(settings);
            
            browser = new CefSharp.WinForms.ChromiumWebBrowser(Properties.Settings.Default["DefaultURL"].ToString())
            {
                Dock = DockStyle.Fill,
                Size = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height),
                Location = new System.Drawing.Point(0,0),

            };
            // This allows Chromium (CEF) to handle downloads
            browser.DownloadHandler=new DownloadHandler();
            // Assign the MaskedTextBox control as the host control's child.
            host.Child = browser;
            
            // Add the interop host control to the Grid
            // control's collection of child controls.
            browser_Stack.Children.Add(host);

            browser.FrameLoadEnd += Browser_FrameLoadEnd;
        }

        private void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        { 
        Voice_handler();
        }

        private async void Voice_handler()
        {
            if (!(bool)Properties.Settings.Default["Mute"])
            {
                int voiceGender = Int32.Parse(Properties.Settings.Default["VoiceGender"].ToString());
                if (voiceGender == 0)
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
                }
                if (voiceGender == 1)
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                }
                if (voiceGender == 2)
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                }

                speechSynthesizer.Volume = 100;
                bool talk = false;
                while (!talk)
                {
                    var textstring = "Welcome";
                    try
                    {
                        string script = string.Format("document.getElementById('speech').value;");
                        await browser.EvaluateScriptAsync(script).ContinueWith(x =>
                        {
                            var response = x.Result;

                            if (response.Success && response.Result != null)
                            {
                                //Delete <u>
                                textstring = response.Result.ToString();
                                string delete1 = "<u>";
                                textstring = textstring.Replace(delete1, "");
                                string delete2 = "</u>";
                                textstring = textstring.Replace(delete2, "");
                                //Delete <strong>
                                delete1 = "<strong>";
                                textstring = textstring.Replace(delete1, "");
                                delete2 = "</strong>";
                                textstring = textstring.Replace(delete2, "");
                                //startDate is the value of a HTML element.
                            }
                            else
                            {

                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        string exc = ex.ToString();
                    }

                    if (text != textstring)
                    {
                        text = textstring;
                        if (text != "Welcome")
                        {
                            speechSynthesizer.Speak(text);
                        }
                    }
                    talk = true;
                }
                await Task.Delay(6000);
                Voice_handler();
            } 
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
            browser = new CefSharp.WinForms.ChromiumWebBrowser(Properties.Settings.Default["DefaultURL"].ToString())
            {
                Dock = DockStyle.Fill,
                Size = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height),
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

        private void Reload()
        {
            browser.Reload();
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

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Form settings = new SettingsForm();
            settings.Show();
        }

        public void Reload(bool ignoreCache = false)
        {
            xd.Reload(ignoreCache);
        }
    }
}
