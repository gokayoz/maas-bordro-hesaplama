namespace MaasBordro.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            dgvPersoneller = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lblPersonelListesi = new Label();
            btnAra = new Button();
            textBox1 = new TextBox();
            cmbMemurDerecesi = new ComboBox();
            lblYonetici = new Label();
            btnGuncelle = new Button();
            btnEkle = new Button();
            panel3 = new Panel();
            rbtnYonetici = new RadioButton();
            rbtnMemur = new RadioButton();
            btnTemizle = new Button();
            txtYoneticiBonusu = new TextBox();
            btnSil = new Button();
            txtCalismaSaati = new TextBox();
            txtSaatlikUcret = new TextBox();
            txtAdSoyad = new TextBox();
            lblMemur = new Label();
            lblCalismaSaati = new Label();
            lblSaatlikUcret = new Label();
            lblUnvan = new Label();
            lblAdSoyad = new Label();
            panel2 = new Panel();
            lblPersonelBilgileri = new Label();
            lblBaslik = new Label();
            pnlBaslik = new Panel();
            tabPage2 = new TabPage();
            panel5 = new Panel();
            btnMailGonder = new Button();
            btnPdf = new Button();
            btnExcel = new Button();
            panel4 = new Panel();
            lblMaasGoruntuleme = new Label();
            dgvRapor = new DataGridView();
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlBaslik.SuspendLayout();
            tabPage2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvPersoneller);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(btnAra);
            splitContainer1.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(cmbMemurDerecesi);
            splitContainer1.Panel2.Controls.Add(lblYonetici);
            splitContainer1.Panel2.Controls.Add(btnGuncelle);
            splitContainer1.Panel2.Controls.Add(btnEkle);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(btnTemizle);
            splitContainer1.Panel2.Controls.Add(txtYoneticiBonusu);
            splitContainer1.Panel2.Controls.Add(btnSil);
            splitContainer1.Panel2.Controls.Add(txtCalismaSaati);
            splitContainer1.Panel2.Controls.Add(txtSaatlikUcret);
            splitContainer1.Panel2.Controls.Add(txtAdSoyad);
            splitContainer1.Panel2.Controls.Add(lblMemur);
            splitContainer1.Panel2.Controls.Add(lblCalismaSaati);
            splitContainer1.Panel2.Controls.Add(lblSaatlikUcret);
            splitContainer1.Panel2.Controls.Add(lblUnvan);
            splitContainer1.Panel2.Controls.Add(lblAdSoyad);
            splitContainer1.Panel2.Controls.Add(panel2);
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.ForeColor = Color.White;
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.AllowUserToAddRows = false;
            dgvPersoneller.AllowUserToDeleteRows = false;
            dgvPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resources.ApplyResources(dgvPersoneller, "dgvPersoneller");
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPersoneller.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.SelectionChanged += dgvPersoneller_SelectionChanged;
            // 
            // Column1
            // 
            resources.ApplyResources(Column1, "Column1");
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(Column2, "Column2");
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(lblPersonelListesi);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // lblPersonelListesi
            // 
            resources.ApplyResources(lblPersonelListesi, "lblPersonelListesi");
            lblPersonelListesi.ForeColor = Color.White;
            lblPersonelListesi.Name = "lblPersonelListesi";
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(0, 123, 255);
            btnAra.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAra, "btnAra");
            btnAra.ForeColor = Color.White;
            btnAra.Name = "btnAra";
            btnAra.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(45, 45, 45);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // cmbMemurDerecesi
            // 
            cmbMemurDerecesi.BackColor = Color.FromArgb(45, 45, 45);
            cmbMemurDerecesi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMemurDerecesi.FormattingEnabled = true;
            cmbMemurDerecesi.Items.AddRange(new object[] { resources.GetString("cmbMemurDerecesi.Items"), resources.GetString("cmbMemurDerecesi.Items1"), resources.GetString("cmbMemurDerecesi.Items2"), resources.GetString("cmbMemurDerecesi.Items3") });
            resources.ApplyResources(cmbMemurDerecesi, "cmbMemurDerecesi");
            cmbMemurDerecesi.Name = "cmbMemurDerecesi";
            // 
            // lblYonetici
            // 
            resources.ApplyResources(lblYonetici, "lblYonetici");
            lblYonetici.ForeColor = Color.White;
            lblYonetici.Name = "lblYonetici";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(0, 123, 255);
            btnGuncelle.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnGuncelle, "btnGuncelle");
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(0, 123, 255);
            btnEkle.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnEkle, "btnEkle");
            btnEkle.ForeColor = Color.White;
            btnEkle.Name = "btnEkle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 45, 45);
            panel3.Controls.Add(rbtnYonetici);
            panel3.Controls.Add(rbtnMemur);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // rbtnYonetici
            // 
            resources.ApplyResources(rbtnYonetici, "rbtnYonetici");
            rbtnYonetici.Name = "rbtnYonetici";
            rbtnYonetici.TabStop = true;
            rbtnYonetici.UseVisualStyleBackColor = true;
            rbtnYonetici.CheckedChanged += rbtnYonetici_CheckedChanged;
            // 
            // rbtnMemur
            // 
            resources.ApplyResources(rbtnMemur, "rbtnMemur");
            rbtnMemur.Name = "rbtnMemur";
            rbtnMemur.TabStop = true;
            rbtnMemur.UseVisualStyleBackColor = true;
            rbtnMemur.CheckedChanged += rbtnMemur_CheckedChanged;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(0, 123, 255);
            btnTemizle.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnTemizle, "btnTemizle");
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Name = "btnTemizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // txtYoneticiBonusu
            // 
            txtYoneticiBonusu.BackColor = Color.FromArgb(45, 45, 45);
            txtYoneticiBonusu.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtYoneticiBonusu, "txtYoneticiBonusu");
            txtYoneticiBonusu.ForeColor = Color.White;
            txtYoneticiBonusu.Name = "txtYoneticiBonusu";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(0, 123, 255);
            btnSil.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnSil, "btnSil");
            btnSil.ForeColor = Color.White;
            btnSil.Name = "btnSil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtCalismaSaati
            // 
            txtCalismaSaati.BackColor = Color.FromArgb(45, 45, 45);
            txtCalismaSaati.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtCalismaSaati, "txtCalismaSaati");
            txtCalismaSaati.ForeColor = Color.White;
            txtCalismaSaati.Name = "txtCalismaSaati";
            // 
            // txtSaatlikUcret
            // 
            txtSaatlikUcret.BackColor = Color.FromArgb(45, 45, 45);
            txtSaatlikUcret.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtSaatlikUcret, "txtSaatlikUcret");
            txtSaatlikUcret.ForeColor = Color.White;
            txtSaatlikUcret.Name = "txtSaatlikUcret";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = Color.FromArgb(45, 45, 45);
            txtAdSoyad.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtAdSoyad, "txtAdSoyad");
            txtAdSoyad.ForeColor = Color.White;
            txtAdSoyad.Name = "txtAdSoyad";
            // 
            // lblMemur
            // 
            resources.ApplyResources(lblMemur, "lblMemur");
            lblMemur.ForeColor = Color.White;
            lblMemur.Name = "lblMemur";
            // 
            // lblCalismaSaati
            // 
            resources.ApplyResources(lblCalismaSaati, "lblCalismaSaati");
            lblCalismaSaati.ForeColor = Color.White;
            lblCalismaSaati.Name = "lblCalismaSaati";
            // 
            // lblSaatlikUcret
            // 
            resources.ApplyResources(lblSaatlikUcret, "lblSaatlikUcret");
            lblSaatlikUcret.ForeColor = Color.White;
            lblSaatlikUcret.Name = "lblSaatlikUcret";
            // 
            // lblUnvan
            // 
            resources.ApplyResources(lblUnvan, "lblUnvan");
            lblUnvan.ForeColor = Color.White;
            lblUnvan.Name = "lblUnvan";
            // 
            // lblAdSoyad
            // 
            resources.ApplyResources(lblAdSoyad, "lblAdSoyad");
            lblAdSoyad.ForeColor = Color.White;
            lblAdSoyad.Name = "lblAdSoyad";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 45);
            panel2.Controls.Add(lblPersonelBilgileri);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // lblPersonelBilgileri
            // 
            resources.ApplyResources(lblPersonelBilgileri, "lblPersonelBilgileri");
            lblPersonelBilgileri.ForeColor = Color.White;
            lblPersonelBilgileri.Name = "lblPersonelBilgileri";
            // 
            // lblBaslik
            // 
            resources.ApplyResources(lblBaslik, "lblBaslik");
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Name = "lblBaslik";
            // 
            // pnlBaslik
            // 
            pnlBaslik.BackColor = Color.FromArgb(34, 34, 34);
            pnlBaslik.Controls.Add(lblBaslik);
            resources.ApplyResources(pnlBaslik, "pnlBaslik");
            pnlBaslik.Name = "pnlBaslik";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(34, 34, 34);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(dgvRapor);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 45, 45);
            panel5.Controls.Add(btnMailGonder);
            panel5.Controls.Add(btnPdf);
            panel5.Controls.Add(btnExcel);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // btnMailGonder
            // 
            btnMailGonder.BackColor = Color.Coral;
            btnMailGonder.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnMailGonder, "btnMailGonder");
            btnMailGonder.ForeColor = Color.White;
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.UseVisualStyleBackColor = false;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.FromArgb(193, 39, 45);
            btnPdf.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnPdf, "btnPdf");
            btnPdf.ForeColor = Color.White;
            btnPdf.Name = "btnPdf";
            btnPdf.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(29, 174, 93);
            btnExcel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnExcel, "btnExcel");
            btnExcel.ForeColor = Color.White;
            btnExcel.Name = "btnExcel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 45, 45);
            panel4.Controls.Add(lblMaasGoruntuleme);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // lblMaasGoruntuleme
            // 
            resources.ApplyResources(lblMaasGoruntuleme, "lblMaasGoruntuleme");
            lblMaasGoruntuleme.ForeColor = Color.White;
            lblMaasGoruntuleme.Name = "lblMaasGoruntuleme";
            // 
            // dgvRapor
            // 
            dgvRapor.AllowUserToAddRows = false;
            dgvRapor.AllowUserToDeleteRows = false;
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column8, Column9, Column5, Column11, Column6, Column7, Column10 });
            resources.ApplyResources(dgvRapor, "dgvRapor");
            dgvRapor.Name = "dgvRapor";
            dgvRapor.ReadOnly = true;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(34, 34, 34);
            tabPage1.Controls.Add(splitContainer1);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // Column3
            // 
            resources.ApplyResources(Column3, "Column3");
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(Column4, "Column4");
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column8
            // 
            resources.ApplyResources(Column8, "Column8");
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            resources.ApplyResources(Column9, "Column9");
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column5
            // 
            resources.ApplyResources(Column5, "Column5");
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column11
            // 
            resources.ApplyResources(Column11, "Column11");
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column6
            // 
            resources.ApplyResources(Column6, "Column6");
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            resources.ApplyResources(Column7, "Column7");
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column10
            // 
            resources.ApplyResources(Column10, "Column10");
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            Controls.Add(tabControl1);
            Controls.Add(pnlBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlBaslik.ResumeLayout(false);
            pnlBaslik.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBaslik;
        private Panel pnlBaslik;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private SplitContainer splitContainer1;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button btnAra;
        private TextBox textBox1;
        private Panel panel1;
        private Label lblPersonelListesi;
        private Panel panel2;
        private Label lblPersonelBilgileri;
        private Label lblAdSoyad;
        private RadioButton rbtnMemur;
        private RadioButton rbtnYonetici;
        private TextBox txtAdSoyad;
        private Label lblMemur;
        private Label lblCalismaSaati;
        private Label lblSaatlikUcret;
        private Label lblUnvan;
        private Button btnTemizle;
        private TextBox txtCalismaSaati;
        private TextBox txtSaatlikUcret;
        private Panel panel3;
        private DataGridView dgvPersoneller;
        private Label lblYonetici;
        private TextBox txtYoneticiBonusu;
        private ComboBox cmbMemurDerecesi;
        private DataGridView dgvRapor;
        private Panel panel4;
        private Panel panel5;
        private Label lblMaasGoruntuleme;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnExcel;
        private Button btnMailGonder;
        private Button btnPdf;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column10;
    }
}
