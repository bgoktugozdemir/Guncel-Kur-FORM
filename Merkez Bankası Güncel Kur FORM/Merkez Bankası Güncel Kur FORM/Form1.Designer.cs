namespace Merkez_Bankası_Güncel_Kur_FORM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblKurlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOVIZDataSet = new Merkez_Bankası_Güncel_Kur_FORM.DOVIZDataSet();
            this.tblKurlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniVeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugününVerisiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihİleVeriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayİleVeriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihFarkıİleHesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblKurlarTableAdapter = new Merkez_Bankası_Güncel_Kur_FORM.DOVIZDataSetTableAdapters.tblKurlarTableAdapter();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TarihCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GunCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USDCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EUROCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POUNDCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKurlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOVIZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKurlarBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TarihCell,
            this.GunCell,
            this.USDCell,
            this.EUROCell,
            this.POUNDCell});
            this.dataGridView1.DataSource = this.tblKurlarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 636);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tblKurlarBindingSource
            // 
            this.tblKurlarBindingSource.DataMember = "tblKurlar";
            this.tblKurlarBindingSource.DataSource = this.dOVIZDataSet;
            // 
            // dOVIZDataSet
            // 
            this.dOVIZDataSet.DataSetName = "DOVIZDataSet";
            this.dOVIZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniVeriToolStripMenuItem,
            this.işlemToolStripMenuItem,
            this.hesapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(300, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniVeriToolStripMenuItem
            // 
            this.yeniVeriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugününVerisiEkleToolStripMenuItem,
            this.tarihİleVeriEkleToolStripMenuItem,
            this.ayİleVeriEkleToolStripMenuItem});
            this.yeniVeriToolStripMenuItem.Name = "yeniVeriToolStripMenuItem";
            this.yeniVeriToolStripMenuItem.Size = new System.Drawing.Size(63, 19);
            this.yeniVeriToolStripMenuItem.Text = "Yeni Veri";
            // 
            // bugününVerisiEkleToolStripMenuItem
            // 
            this.bugününVerisiEkleToolStripMenuItem.Name = "bugününVerisiEkleToolStripMenuItem";
            this.bugününVerisiEkleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.bugününVerisiEkleToolStripMenuItem.Text = "Bugünün Verisi Ekle";
            this.bugününVerisiEkleToolStripMenuItem.Click += new System.EventHandler(this.bugününVerisiEkleToolStripMenuItem_Click);
            // 
            // tarihİleVeriEkleToolStripMenuItem
            // 
            this.tarihİleVeriEkleToolStripMenuItem.Name = "tarihİleVeriEkleToolStripMenuItem";
            this.tarihİleVeriEkleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.tarihİleVeriEkleToolStripMenuItem.Text = "Tarih ile Veri Ekle";
            this.tarihİleVeriEkleToolStripMenuItem.Click += new System.EventHandler(this.tarihİleVeriEkleToolStripMenuItem_Click);
            // 
            // ayİleVeriEkleToolStripMenuItem
            // 
            this.ayİleVeriEkleToolStripMenuItem.Name = "ayİleVeriEkleToolStripMenuItem";
            this.ayİleVeriEkleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ayİleVeriEkleToolStripMenuItem.Text = "Ay ile Veri Ekle";
            this.ayİleVeriEkleToolStripMenuItem.Click += new System.EventHandler(this.ayİleVeriEkleToolStripMenuItem_Click);
            // 
            // işlemToolStripMenuItem
            // 
            this.işlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarihFarkıİleHesaplaToolStripMenuItem});
            this.işlemToolStripMenuItem.Name = "işlemToolStripMenuItem";
            this.işlemToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.işlemToolStripMenuItem.Text = "İşlem";
            // 
            // tarihFarkıİleHesaplaToolStripMenuItem
            // 
            this.tarihFarkıİleHesaplaToolStripMenuItem.Name = "tarihFarkıİleHesaplaToolStripMenuItem";
            this.tarihFarkıİleHesaplaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tarihFarkıİleHesaplaToolStripMenuItem.Text = "Tarih Farkı İle Hesapla";
            this.tarihFarkıİleHesaplaToolStripMenuItem.Click += new System.EventHandler(this.tarihFarkıİleHesaplaToolStripMenuItem_Click);
            // 
            // tblKurlarTableAdapter
            // 
            this.tblKurlarTableAdapter.ClearBeforeFill = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 622);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 39);
            this.progressBar1.Step = 31;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // TarihCell
            // 
            this.TarihCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TarihCell.DataPropertyName = "Tarih";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.TarihCell.DefaultCellStyle = dataGridViewCellStyle13;
            this.TarihCell.HeaderText = "Tarih";
            this.TarihCell.Name = "TarihCell";
            this.TarihCell.ReadOnly = true;
            this.TarihCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TarihCell.Width = 54;
            // 
            // GunCell
            // 
            this.GunCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GunCell.DataPropertyName = "Gün";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GunCell.DefaultCellStyle = dataGridViewCellStyle14;
            this.GunCell.HeaderText = "Gün";
            this.GunCell.Name = "GunCell";
            this.GunCell.ReadOnly = true;
            this.GunCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GunCell.Visible = false;
            this.GunCell.Width = 45;
            // 
            // USDCell
            // 
            this.USDCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.USDCell.DataPropertyName = "USD";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.USDCell.DefaultCellStyle = dataGridViewCellStyle15;
            this.USDCell.HeaderText = "USD $";
            this.USDCell.Name = "USDCell";
            this.USDCell.ReadOnly = true;
            this.USDCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.USDCell.Width = 59;
            // 
            // EUROCell
            // 
            this.EUROCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EUROCell.DataPropertyName = "EURO";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.EUROCell.DefaultCellStyle = dataGridViewCellStyle16;
            this.EUROCell.HeaderText = "EURO €";
            this.EUROCell.Name = "EUROCell";
            this.EUROCell.ReadOnly = true;
            this.EUROCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EUROCell.Width = 71;
            // 
            // POUNDCell
            // 
            this.POUNDCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.POUNDCell.DataPropertyName = "POUND";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.POUNDCell.DefaultCellStyle = dataGridViewCellStyle17;
            this.POUNDCell.HeaderText = "POUND £";
            this.POUNDCell.Name = "POUNDCell";
            this.POUNDCell.ReadOnly = true;
            this.POUNDCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.POUNDCell.Width = 81;
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.hesapToolStripMenuItem.Text = "Hesap";
            this.hesapToolStripMenuItem.Click += new System.EventHandler(this.hesapToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 661);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKurlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOVIZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKurlarBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DOVIZDataSet dOVIZDataSet;
        private System.Windows.Forms.BindingSource tblKurlarBindingSource;
        private DOVIZDataSetTableAdapters.tblKurlarTableAdapter tblKurlarTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniVeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugününVerisiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarihİleVeriEkleToolStripMenuItem;
        private System.Windows.Forms.BindingSource tblKurlarBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem ayİleVeriEkleToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem işlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarihFarkıİleHesaplaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarihCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn GunCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn USDCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn EUROCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn POUNDCell;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
    }
}

