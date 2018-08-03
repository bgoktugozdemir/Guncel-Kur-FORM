namespace Merkez_Bankası_Güncel_Kur_FORM
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.Transparent;
            this.btnCANCEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.ForeColor = System.Drawing.Color.Red;
            this.btnCANCEL.Location = new System.Drawing.Point(493, 45);
            this.btnCANCEL.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(163, 44);
            this.btnCANCEL.TabIndex = 5;
            this.btnCANCEL.Text = "İptal Et";
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            this.btnCANCEL.MouseLeave += new System.EventHandler(this.btnCANCEL_MouseLeave);
            this.btnCANCEL.MouseHover += new System.EventHandler(this.btnCANCEL_MouseHover);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(16, 45);
            this.btnOK.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(163, 44);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            this.btnOK.MouseHover += new System.EventHandler(this.btnOK_MouseHover);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dateTimePicker1.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(672, 33);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCANCEL;
            this.ClientSize = new System.Drawing.Size(672, 100);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}