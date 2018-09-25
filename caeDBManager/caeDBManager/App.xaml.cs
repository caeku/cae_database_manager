using System;
using System.Windows;

namespace caeDBManager
{
    
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //connection_strings
        public static String connectionString = "Datasource=localhost;Database=cae_workstudy;user=root;";
        public static String sessions_table = "sessions";
        public static String workers_table = "workers";
        public static String admin_table = "user";
        //public static String url = "https://www.facebook.com/";
        public static String url = "http://localhost/projects/workStudy/";
        //public static String url = "http://localhost/workStudy";
    }
}
