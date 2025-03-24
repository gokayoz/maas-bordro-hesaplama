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
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            lblBaslik = new Label();
            pnlBaslik = new Panel();
            tabPage4 = new TabPage();
            tabPage2 = new TabPage();
            tabControl1 = new TabControl();
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
            splitContainer1.Panel1.Controls.Add(button1);
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
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
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
            dgvPersoneller.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
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
            // Column3
            // 
            resources.ApplyResources(Column3, "Column3");
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 123, 255);
            button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
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
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.White;
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.White;
            label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.White;
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 45);
            panel2.Controls.Add(label2);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
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
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(34, 34, 34);
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(34, 34, 34);
            tabPage2.Controls.Add(splitContainer1);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
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
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBaslik;
        private Panel pnlBaslik;
        private TabPage tabPage4;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private SplitContainer splitContainer1;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private RadioButton rbtnMemur;
        private RadioButton rbtnYonetici;
        private TextBox txtAdSoyad;
        private Label lblMemur;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnTemizle;
        private TextBox txtCalismaSaati;
        private TextBox txtSaatlikUcret;
        private Panel panel3;
        private DataGridView dgvPersoneller;
        private Label lblYonetici;
        private TextBox txtYoneticiBonusu;
        private ComboBox cmbMemurDerecesi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
