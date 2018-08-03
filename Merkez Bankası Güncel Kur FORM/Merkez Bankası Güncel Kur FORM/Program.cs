using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merkez_Bankası_Güncel_Kur_FORM.Properties;

namespace Merkez_Bankası_Güncel_Kur_FORM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static bool _isLicenced;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TODO: REMOVE BEGIN
            //Settings.Default.Reset();
            //Settings.Default.Save();
            //TODO: REMOVE END
            Run();
        }

        public static void Run()
        {
            _isLicenced = Settings.Default.IsLicenced;

            LoginScreen loginScreen = new LoginScreen();
            Form1.licenseExpirationDate = loginScreen.ControlExpirationDateFromDB();
            Form1.licenseStartingDate = loginScreen.ControlStartingDateFromDB();
            if (_isLicenced && Form1.licenseExpirationDate > DateTime.Now)
            {
                Application.Run(new Form1());
            }
            else
            {
                if (_isLicenced)
                {
                    MessageBox.Show($"Lisansınızın süresi dolmuş. {Form1.licenseExpirationDate}");
                }
                Settings.Default.IsLicenced = false;
                Settings.Default.Save();
                Application.Run(loginScreen);
            }
        }
    }
}
