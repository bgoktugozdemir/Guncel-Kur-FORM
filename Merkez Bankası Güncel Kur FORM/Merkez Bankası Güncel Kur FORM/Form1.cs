using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using SplashScreen;

namespace Merkez_Bankası_Güncel_Kur_FORM
{
    public partial class Form1 : Form
    {
        static DateTime exchangeDate;
        static string USD;
        static string EURO;
        static string POUND;
        public static string version = "1.2.3";
        public static string username = Properties.Settings.Default.Username;
        public static DateTime licenseExpirationDate;
        public static DateTime licenseStartingDate;
        public static Color UpColor = Color.LimeGreen;
        public static Color DownColor = Color.Firebrick;
        public static Color NotChangedColor = Color.Black;
        private Thread fillDataViewThread;
        private LoginScreen _loginScreen = new LoginScreen();
        private Thread licenseThread;
        static XmlDocument xmlDoc = new XmlDocument();

        CultureInfo culture = new CultureInfo("us");

        //SplashScreen.SplashForm form = new SplashForm();

        public Form1()
        {
            //Thread thread = new Thread(new ThreadStart(Splash));
            //thread.Start();
            InitializeComponent();
            this.Text += $" (v{version}) | Expiration Date [{licenseExpirationDate.ToShortDateString()}]";
            
            ////Loading Data
            //string str = string.Empty;
            //for (int i = 0; i < 10000; i++)
            //{
            //    str += i.ToString();
            //}
            //thread.Abort();
        }

        void ControlLicense()
        {
            _loginScreen = new LoginScreen();
            licenseExpirationDate = _loginScreen.ControlExpirationDateFromDB();
            if (licenseExpirationDate <= DateTime.Now)
            {
                Application.Restart();
            }
        }

        //void Splash()
        //{
        //    form.AppName = "Açılıyor";
        //    Application.Run(form);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOVIZDataSet.tblKurlar' table. You can move, or remove it, as needed.
            CheckForIllegalCrossThreadCalls = false;
            FillDataView();
        }

        public delegate void SetFillDataView();
        public void FillDataView()
        {
            this.tblKurlarTableAdapter.Fill(this.dOVIZDataSet.tblKurlar);
            dataGridView1.Sort(dataGridView1.Columns["TarihCell"], ListSortDirection.Descending);
            SetCellColor();
        }

        private void SetCellColor()
        {
            DataGridViewCellStyle upStyle = new DataGridViewCellStyle
            {
                BackColor = UpColor,
                ForeColor = Color.White
            };
            DataGridViewCellStyle downStyle = new DataGridViewCellStyle
            {
                BackColor = DownColor,
                ForeColor = Color.White
            };
            int rowCount = dataGridView1.RowCount;
            int columnCount = dataGridView1.ColumnCount;

            DataGridViewColumn selectedUSDColumn = dataGridView1.Columns["USDCell"];
            DataGridViewColumn selectedEUROColumn = dataGridView1.Columns["EUROCell"];
            DataGridViewColumn selectedPOUNDColumn = dataGridView1.Columns["POUNDCell"];

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[selectedUSDColumn.DisplayIndex].Value) < Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[selectedUSDColumn.DisplayIndex].Value))
                {
                    dataGridView1.Rows[i].Cells[selectedUSDColumn.DisplayIndex].Style = downStyle;
                }
                else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[selectedUSDColumn.DisplayIndex].Value) > Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[selectedUSDColumn.DisplayIndex].Value))
                {
                    dataGridView1.Rows[i].Cells[selectedUSDColumn.DisplayIndex].Style = upStyle;
                }

                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[selectedEUROColumn.DisplayIndex].Value) < Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[selectedEUROColumn.DisplayIndex].Value))
                {
                    dataGridView1.Rows[i].Cells[selectedEUROColumn.DisplayIndex].Style = downStyle;
                }
                else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[selectedEUROColumn.DisplayIndex].Value) > Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[selectedEUROColumn.DisplayIndex].Value))
                {
                    dataGridView1.Rows[i].Cells[selectedEUROColumn.DisplayIndex].Style = upStyle;
                }

                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[selectedPOUNDColumn.DisplayIndex].Value) < Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[selectedPOUNDColumn.DisplayIndex].Value))
                {
                    dataGridView1.Rows[i].Cells[selectedPOUNDColumn.DisplayIndex].Style = downStyle;
                }
                else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[selectedPOUNDColumn.DisplayIndex].Value) > Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[selectedPOUNDColumn.DisplayIndex].Value))
                {
                    dataGridView1.Rows[i].Cells[selectedPOUNDColumn.DisplayIndex].Style = upStyle;
                }
            }
            
        }

        private void AddValue()
        {
            string today = "http://www.tcmb.gov.tr/kurlar/today.xml";

            try
            {
                xmlDoc.Load(today);
            }
            catch
            {
                MessageBox.Show("Siteye ulaşılamadığı için veri çekilemedi!");
                return;
            }

            SaveToDatabase();
        }

        private void AddValue(string d, string m, string y)
        {
            string anyDays = $"http://www.tcmb.gov.tr/kurlar/{y}{m}/{d}{m}{y}.xml";

            try
            {
                xmlDoc.Load(anyDays);
            }
            catch
            {
                MessageBox.Show($"Siteye ulaşılamadığı için veri çekilemedi! {d}/{m}/{y}");
                return;
            }
            SaveToDatabase();
        }

        private void AddValue(string m, string y)
        {
            float barPercent = 100 / progressBar1.Step;
            float bar = 0;
            progressBar1.Visible = true;
            for (int i = 1; i < 31; i++)
            {
                string d = i.ToString("00");
                string anyDays = $"http://www.tcmb.gov.tr/kurlar/{y}{m}/{d}{m}{y}.xml";

                try
                {
                    xmlDoc.Load(anyDays);
                }
                catch
                {
                    continue;
                }
                SaveToDatabaseMonth();
                bar += barPercent;
                progressBar1.Value = Convert.ToInt32(bar);
            }
            if (InvokeRequired)
                BeginInvoke(new SetFillDataView(FillDataView));
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        private void SaveToDatabaseMonth()
        {
            exchangeDate = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            POUND = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

            float usd = float.Parse(USD, culture);
            float euro = float.Parse(EURO, culture);
            float pound = float.Parse(POUND, culture);

            try
            {
                this.tblKurlarTableAdapter.Insert(exchangeDate.Date, usd, euro, pound, exchangeDate.DayOfWeek.ToString());
            }
            catch
            {
            }
        }

        private void SaveToDatabase()
        {
            exchangeDate = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            POUND = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

            float usd = float.Parse(USD, culture);
            float euro = float.Parse(EURO, culture);
            float pound = float.Parse(POUND, culture);

            try
            {
                this.tblKurlarTableAdapter.Insert(exchangeDate.Date, usd, euro, pound, exchangeDate.DayOfWeek.ToString());
            }
            catch
            {
            }
            FillDataView();
        }

        private void bugününVerisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddValue();
        }

        private void tarihİleVeriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string d;
            string m;
            string y;

            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (form2.isReady)
            {
                d = Form2.dateTime.Day.ToString("00");
                m = Form2.dateTime.Month.ToString("00");
                y = Form2.dateTime.Year.ToString();
                AddValue(d,m,y);
            }
        }
        private void ayİleVeriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m;
            string y;

            Form3 form3 = new Form3();
            form3.ShowDialog();

            if (form3.isReady)
            {
                m = Form3.dateTime.Month.ToString("00");
                y = Form3.dateTime.Year.ToString();

                Thread thread = new Thread(() => AddValue(m, y));
                //thread.IsBackground = true;
                thread.Start();
            }
        }

        private void tarihFarkıİleHesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(Object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void hesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            licenseExpirationDate = _loginScreen.ControlExpirationDateFromDB();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            licenseThread = new Thread(ControlLicense);
            licenseThread.Start();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _loginScreen.DeleteRowFromDB((DateTime)((DataGridView)sender).CurrentRow.Cells[0].Value);
            FillDataView();
        }

        private void tarihİleVeriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silmek istediğiniz tarihlerin üzerine çift tıklamanız yeterlidir.","İPUCU",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ayİleVeriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m;
            string y;

            Form3 form3 = new Form3();
            form3.ShowDialog();

            if (form3.isReady)
            {
                m = Form3.dateTime.Month.ToString("00");
                y = Form3.dateTime.Year.ToString();

                Thread thread = new Thread(() => DeleteValue(m, y));
                thread.Start();
            }
        }

        private void DeleteValue(string m, string y)
        {
            float barPercent = 100 / progressBar1.Step;
            float bar = 0;
            progressBar1.Visible = true;
            string query = "DELETE FROM tblKurlar " +
                           "WHERE Tarih=@Tarih ";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DOVIZ);
            SqlCommand command;
            connection.Open();
            for (int d = 1; d <= 31; d++)
            {
                command = new SqlCommand(query,connection);
                string tarih = $"{y}-{m}-{d:00}";
                command.Parameters.AddWithValue("@Tarih", tarih);
                command.ExecuteNonQuery();
                bar += barPercent;
                progressBar1.Value = Convert.ToInt32(bar);
            }
            connection.Close();
            if (InvokeRequired)
                BeginInvoke(new SetFillDataView(FillDataView));
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }
    }
}
