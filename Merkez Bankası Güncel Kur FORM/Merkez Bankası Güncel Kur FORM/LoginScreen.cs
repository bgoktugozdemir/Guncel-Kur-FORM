using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Merkez_Bankası_Güncel_Kur_FORM.Properties;
using static Merkez_Bankası_Güncel_Kur_FORM.Program;

namespace Merkez_Bankası_Güncel_Kur_FORM
{
    public partial class LoginScreen : Form
    {
        public SqlConnection Connection;
        public SqlCommand Command;

        public LoginScreen()
        {
            InitializeComponent();
            SQL();
        }

        public void SQL()
        {
            Connection = new SqlConnection(Settings.Default.DOVIZ);
        }

        private bool GetLicenseFromDB(string licenseKey)
        {
            Connection.Open();
            string query = "SELECT * " +
                           "FROM tblLicense " +
                           "WHERE LicenseKey = @LicenseKey AND IsUsed = 0";
            try
            {
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@LicenseKey", licenseKey);
                Settings.Default.LicenseKey = Command.ExecuteScalar().ToString();
                Connection.Close();
                
                if (SetLicenseFromDB())
                {
                    return true;
                }
                Settings.Default.Save();

            }
            catch (Exception e)
            {
                MessageBox.Show("LİSANS HATALI VEYA DAHA ÖNCE KULLANILMIŞ! \n");
            }

            Connection.Close();
            return false;
        }

        public DateTime ControlExpirationDateFromDB()
        {
            DateTime ExpirationDate = DateTime.MinValue;
            Connection.Open();
            string query = "SELECT ExpirationDate " +
                           "FROM tblLicense " +
                           "WHERE LicenseKey = @LicenseKey";
            try
            {

                var Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@LicenseKey", Settings.Default.LicenseKey);
                ExpirationDate = (DateTime)Command.ExecuteScalar();
                //Settings.Default.Save();
                //if (SetLicenseFromDB())
                //{
                //    return ExpirationDate;
                //}

            }
            catch (Exception e)
            {
                MessageBox.Show($"Lisans Süresi Dolmuş ({ExpirationDate.ToString()})");
            }
            finally
            {
                Connection.Close();
            }
            return ExpirationDate;
        }

        public DateTime ControlStartingDateFromDB()
        {
            DateTime StartingDate = DateTime.MinValue;
            Connection.Open();
            string query = "SELECT StartingDate " +
                           "FROM tblLicense " +
                           "WHERE LicenseKey = @LicenseKey";
            try
            {

                var Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@LicenseKey", Settings.Default.LicenseKey);
                StartingDate = (DateTime)Command.ExecuteScalar();
                //if (SetLicenseFromDB())
                //{
                //    return ExpirationDate;
                //}

            }
            catch (Exception e)
            {
            }
            finally
            {
                Connection.Close();
            }
            return StartingDate;
        }

        private bool SetLicenseFromDB()
        {
            string query = "UPDATE tblLicense " +
                           "SET Username = @Username ,StartingDate = GETDATE(), ExpirationDate = DATEADD(DAY, DateLimit, GETDATE()), IsUsed = 1 " +
                           "WHERE LicenseKey = @LicenseKey AND IsUsed = 0";

            Connection.Open();
            try
            {
                var cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@LicenseKey", tbLicense.Text);
                cmd.ExecuteNonQuery();
                Connection.Close();
                Settings.Default.Username = tbUsername.Text;
                Settings.Default.Save();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("HATALI LİSANS! \n");
            }

            return false;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            tbUsername.Text = Settings.Default.Username;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (GetLicenseFromDB(tbLicense.Text))
            {
                Settings.Default.IsLicenced = true;
                Settings.Default.Save();
                Application.Restart();
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbLicense.Text.Length % 6 == 5)
            {
                tbLicense.Text += '-';
            }
        }
    }
}
