using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merkez_Bankası_Güncel_Kur_FORM
{
    public partial class Form2 : Form
    {
        public static DateTime dateTime = DateTime.Today;
        public bool isReady = false;
        private Color btnOK_DefaultFC;
        private Color btnOK_DefaultBC;
        private Color btnCANCEL_DefaultFC;
        private Color btnCANCEL_DefaultBC;

        public Form2()
        {
            InitializeComponent();
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            dateTime = dateTimePicker1.Value;
            isReady = true;
            this.Close();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            btnOK_DefaultFC = btnOK.ForeColor;
            btnOK_DefaultBC = btnOK.BackColor;
            btnCANCEL_DefaultFC = btnCANCEL.ForeColor;
            btnCANCEL_DefaultBC = btnCANCEL.BackColor;
            dateTimePicker1.Cursor = Cursors.Hand;
        }
    }
}
