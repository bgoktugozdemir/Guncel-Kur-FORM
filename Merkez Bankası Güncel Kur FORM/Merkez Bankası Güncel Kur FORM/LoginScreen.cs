using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Merkez_Bankası_Güncel_Kur_FORM.Properties;
using static Merkez_Bankası_Güncel_Kur_FORM.Program;

namespace Merkez_Bankası_Güncel_Kur_FORM
{
    public partial class LoginScreen : Form
    {
        public SqlConnection Connection;
        public SqlCommand Command;
        private Color btnOK_DefaultFC;
        private Color btnOK_DefaultBC;
        private Color btnCANCEL_DefaultFC;
        private Color btnCANCEL_DefaultBC;
        private Color btnPASTE_DefaultFC;
        private Color btnPASTE_DefaultBC;

        public LoginScreen()
        {
            InitializeComponent();
            SQL();
        }

        public void SQL()
        {
            Connection = new SqlConnection(Settings.Default.DOVIZ);
        }
        
        public bool GetLicenseFromDB(string licenseKey)
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
                
                if (SetLicenseFromDB(licenseKey))
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
                MessageBox.Show($"Lisans Süresi Dolmuş!");
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

        private bool SetLicenseFromDB(string licenseKey)
        {
            string query = "UPDATE tblLicense " +
                           "SET Username = @Username ,StartingDate = GETDATE(), ExpirationDate = DATEADD(DAY, DateLimit, GETDATE()), IsUsed = 1 " +
                           "WHERE LicenseKey = @LicenseKey AND IsUsed = 0";

            Connection.Open();
            try
            {
                var cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@LicenseKey", licenseKey);
                bool noError = Convert.ToBoolean(cmd.ExecuteNonQuery());
                Connection.Close();

                if (noError)
                {
                    Settings.Default.Username = tbUsername.Text;
                    Settings.Default.Save();
                    return true;
                }

                Exception e = new Exception("Error");
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

            btnOK_DefaultFC = btnOK.ForeColor;
            btnOK_DefaultBC = btnOK.BackColor;
            btnCANCEL_DefaultFC = btnCANCEL.ForeColor;
            btnCANCEL_DefaultBC = btnCANCEL.BackColor;
            btnPASTE_DefaultFC = btnPaste.ForeColor;
            btnPASTE_DefaultBC = btnPaste.BackColor;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string license = String.Format($"{tbLicense_1.Text}-{tbLicense_2.Text}-{tbLicense_3.Text}-{tbLicense_4.Text}-{tbLicense_5.Text}");
            if (GetLicenseFromDB(license))
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

        private void NextTextBox(TextBox licenseTextBox)
        {
            if (licenseTextBox.Text.Length == 5)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbLicense_1_TextChanged(object sender, EventArgs e)
        {
            NextTextBox(tbLicense_1);
        }

        private void tbLicense_2_TextChanged(object sender, EventArgs e)
        {
            NextTextBox(tbLicense_2);
        }

        private void tbLicense_3_TextChanged(object sender, EventArgs e)
        {
            NextTextBox(tbLicense_3);
        }

        private void tbLicense_4_TextChanged(object sender, EventArgs e)
        {
            NextTextBox(tbLicense_4);
        }

        private void tbLicense_5_TextChanged(object sender, EventArgs e)
        {
            NextTextBox(tbLicense_5);
        }

        private void PastePress()
        {
            string clipboardText = Clipboard.GetText(TextDataFormat.Text);
            if (clipboardText.Length != (5 * tbLicense_1.MaxLength + 4))
            {
                MessageBox.Show("Şifre formatı yanlış.","Hatalı Format", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            tbLicense_1.Text = clipboardText.Substring(0, 5);
            tbLicense_2.Text = clipboardText.Substring(6, 5);
            tbLicense_3.Text = clipboardText.Substring(12, 5);
            tbLicense_4.Text = clipboardText.Substring(18, 5);
            tbLicense_5.Text = clipboardText.Substring(24, 5);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            PastePress();
        }

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            btnOK.BackColor = btnOK.ForeColor;
            btnOK.ForeColor = Color.Black;
        }

        private void btnCANCEL_MouseHover(object sender, EventArgs e)
        {
            btnCANCEL.BackColor = btnCANCEL.ForeColor;
            btnCANCEL.ForeColor = Color.Black;
        }

        private void btnPASTE_MouseHover(object sender, EventArgs e)
        {
            btnPaste.BackColor = btnPaste.ForeColor;
            btnPaste.ForeColor = Color.Black;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.ForeColor = btnOK_DefaultFC;
            btnOK.BackColor = btnOK_DefaultBC;
        }

        private void btnCANCEL_MouseLeave(object sender, EventArgs e)
        {
            btnCANCEL.ForeColor = btnCANCEL_DefaultFC;
            btnCANCEL.BackColor = btnCANCEL_DefaultBC;
        }

        private void btnPASTE_MouseLeave(object sender, EventArgs e)
        {
            btnPaste.ForeColor = btnPASTE_DefaultFC;
            btnPaste.BackColor = btnCANCEL_DefaultBC;
        }

        public void DeleteRowFromDB(DateTime time)
        {
            string query = "DELETE FROM tblKurlar " +
                           "WHERE Tarih=@Tarih";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Tarih", time.Year+"-"+time.Month.ToString("00")+"-"+time.Day.ToString("00"));
            Command.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
