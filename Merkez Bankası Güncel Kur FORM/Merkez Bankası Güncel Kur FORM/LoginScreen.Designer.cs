namespace Merkez_Bankası_Güncel_Kur_FORM
{
    partial class LoginScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.Transparent;
            this.btnCANCEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnCANCEL.ForeColor = System.Drawing.Color.Red;
            this.btnCANCEL.Location = new System.Drawing.Point(298, 100);
            this.btnCANCEL.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(103, 33);
            this.btnCANCEL.TabIndex = 5;
            this.btnCANCEL.Text = "Kapat";
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(19, 100);
            this.btnOK.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 33);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lisans Kodu:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(128, 16);
            this.tbUsername.MaxLength = 12;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(277, 26);
            this.tbUsername.TabIndex = 8;
            // 
            // tbLicense
            // 
            this.tbLicense.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLicense.Location = new System.Drawing.Point(128, 57);
            this.tbLicense.MaxLength = 29;
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(277, 26);
            this.tbLicense.TabIndex = 9;
            this.tbLicense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLicense_KeyPress);
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnCANCEL;
            this.ClientSize = new System.Drawing.Size(424, 144);
            this.Controls.Add(this.tbLicense);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(440, 259);
            this.MinimumSize = new System.Drawing.Size(440, 183);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbLicense;
    }
}