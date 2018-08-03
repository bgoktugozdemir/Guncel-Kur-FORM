using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace Merkez_Bankası_Güncel_Kur_FORM
{
    public partial class Form4 : Form
    {
        public static DateTime dateTime1 = DateTime.Today.AddDays(-1);
        public static DateTime dateTime2 = DateTime.Today;
        private Color btnOK_DefaultFC;
        private Color btnOK_DefaultBC;
        private Color btnCANCEL_DefaultFC;
        private Color btnCANCEL_DefaultBC;

        CultureInfo culture = new CultureInfo("us");


        public Form4()
        {
            InitializeComponent();
        }

        private double[] FarkHesapla()
        {
            string d1, d2;
            string m1, m2;
            string y1, y2;

            d1 = dateTime1.Day.ToString("00");
            m1 = dateTime1.Month.ToString("00");
            y1 = dateTime1.Year.ToString();
            d2 = dateTime2.Day.ToString("00");
            m2 = dateTime2.Month.ToString("00");
            y2 = dateTime2.Year.ToString();

            string day1 = $"http://www.tcmb.gov.tr/kurlar/{y1}{m1}/{d1}{m1}{y1}.xml";
            string day2 = $"http://www.tcmb.gov.tr/kurlar/{y2}{m2}/{d2}{m2}{y2}.xml";
            XmlDocument xmlDoc1 = new XmlDocument();
            XmlDocument xmlDoc2 = new XmlDocument();
            try
            {
                xmlDoc1.Load(day1);
                xmlDoc2.Load(day2);
            }
            catch
            {
                MessageBox.Show($"Sisteme ulaşılamadığı için veri çekilemedi! İnternet bağlantınızı ve tarihleri kontrol ediniz.");
                return null;
            }
            double[] monies = new double[9];

            monies[0] = Convert.ToDouble(xmlDoc1.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml, culture);
            monies[1] = Convert.ToDouble(xmlDoc1.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml, culture);
            monies[2] = Convert.ToDouble(xmlDoc1.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml, culture);

            monies[3] = Convert.ToDouble(xmlDoc2.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml, culture);
            monies[4] = Convert.ToDouble(xmlDoc2.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml, culture);
            monies[5] = Convert.ToDouble(xmlDoc2.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml, culture);

            monies[6] = monies[3] - monies[0];
            monies[7] = monies[4] - monies[1];
            monies[8] = monies[5] - monies[2];

            return monies;
        }
        public void btnOK_Click(object sender, EventArgs e)
        {
            dateTime1 = dateTimePicker1.Value;
            dateTime2 = dateTimePicker2.Value;
            if (dateTime1 >= dateTime2)
            {
                MessageBox.Show("İkinci Tarih, Birinci Tarih'den büyük olmalıdır!");
                return;
            }

            textBox1.Text = dateTime1.ToShortDateString();
            textBox2.Text = dateTime2.ToShortDateString();
            textBox3.Text = Convert.ToInt32((dateTime2 - dateTime1).TotalDays).ToString();
           
            double[] moneies = FarkHesapla();
            if (moneies == null)
                return;
            textBox4_USD1.Text = moneies[0].ToString("C");
            textBox4_EURO1.Text = moneies[1].ToString("C");
            textBox4_POUND1.Text = moneies[2].ToString("C");
            textBox4_USD2.Text = moneies[3].ToString("C");
            textBox4_EURO2.Text = moneies[4].ToString("C");
            textBox4_POUND2.Text = moneies[5].ToString("C");
            textBox4_USD.Text = moneies[6].ToString("C");
            textBox4_EURO.Text = moneies[7].ToString("C");
            textBox4_POUND.Text = moneies[8].ToString("C");

            #region BGColor
            
            if (moneies[6] > 0)
            {
                textBox4_USD.BackColor = Form1.UpColor;
            }
            else if (moneies[6] < 0)
            {
                textBox4_USD.BackColor = Form1.DownColor;
            }
            else
            {
                textBox4_USD.BackColor = Form1.NotChangedColor;
            }

            if (moneies[7] > 0)
            {
                textBox4_EURO.BackColor = Form1.UpColor;
            }
            else if (moneies[7] < 0)
            {
                textBox4_EURO.BackColor = Form1.DownColor;
            }
            else
            {
                textBox4_EURO.BackColor = Form1.NotChangedColor;
            }

            if (moneies[8] > 0)
            {
                textBox4_POUND.BackColor = Form1.UpColor;
            }
            else if (moneies[8] < 0)
            {
                textBox4_POUND.BackColor = Form1.DownColor;
            }
            else
            {
                textBox4_POUND.BackColor = Form1.NotChangedColor;
            }

            #endregion

            groupBox1.Visible = true;
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            btnOK.BackColor = btnOK.ForeColor;
            btnOK.ForeColor = Color.White;
        }

        private void btnCANCEL_MouseHover(object sender, EventArgs e)
        {
            btnCANCEL.BackColor = btnCANCEL.ForeColor;
            btnCANCEL.ForeColor = Color.White;
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

        private void Form4_Load(object sender, EventArgs e)
        {
            btnOK_DefaultFC = btnOK.ForeColor;
            btnOK_DefaultBC = btnOK.BackColor;
            btnCANCEL_DefaultFC = btnCANCEL.ForeColor;
            btnCANCEL_DefaultBC = btnCANCEL.BackColor;
            dateTimePicker1.Value = dateTime1;
            dateTimePicker2.Value = dateTime2;
        }
    }
}
