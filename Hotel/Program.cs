using Hotel.Entities;
using System;
using System.Windows.Forms;

namespace Hotel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public enum Role
        {
            ADMIN,
            MANAGER,
            STAFF
        }

        public static class Global
        {
            // Quang 
            //public static string serverName = "(localdb)\\MSSQLLocalDB";
            // Dung
            public static string serverName = "DESKTOP-7TB6IV3";

            public static bool isAuth = false;
            public static ManagerEntity manager = null;
            public static StaffEntity staff = null;
            public static AdminEntity admin = null;
            public static Role? role = null;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NavigationForm());
        }
    }
}
