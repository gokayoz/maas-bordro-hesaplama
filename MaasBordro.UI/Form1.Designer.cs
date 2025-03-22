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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlBaslik = new Panel();
            lblBaslik = new Label();
            pnlMenu = new Panel();
            btnRaporlar = new Button();
            btnAnasayfa = new Button();
            btnMaasHesaplama = new Button();
            btnPersonelListesi = new Button();
            pnlAnasayfa = new Panel();
            pnlSonIslemler = new Panel();
            dgvSonIslemler = new DataGridView();
            lblSonIslemlerBaslik = new Label();
            pnlKart4 = new Panel();
            label1 = new Label();
            pnlKart3 = new Panel();
            label3 = new Label();
            pnlKart2 = new Panel();
            lbl = new Label();
            pnlKart1 = new Panel();
            lblKart1Deger = new Label();
            lblKart1Baslik = new Label();
            pnlPersonelListesi = new Panel();
            pnlBaslik.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlAnasayfa.SuspendLayout();
            pnlSonIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSonIslemler).BeginInit();
            pnlKart4.SuspendLayout();
            pnlKart3.SuspendLayout();
            pnlKart2.SuspendLayout();
            pnlKart1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBaslik
            // 
            pnlBaslik.BackColor = Color.FromArgb(34, 34, 34);
            pnlBaslik.Controls.Add(lblBaslik);
            resources.ApplyResources(pnlBaslik, "pnlBaslik");
            pnlBaslik.Name = "pnlBaslik";
            // 
            // lblBaslik
            // 
            resources.ApplyResources(lblBaslik, "lblBaslik");
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Name = "lblBaslik";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(45, 45, 45);
            pnlMenu.Controls.Add(btnRaporlar);
            pnlMenu.Controls.Add(btnAnasayfa);
            pnlMenu.Controls.Add(btnMaasHesaplama);
            pnlMenu.Controls.Add(btnPersonelListesi);
            resources.ApplyResources(pnlMenu, "pnlMenu");
            pnlMenu.Name = "pnlMenu";
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.FromArgb(45, 45, 45);
            btnRaporlar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRaporlar, "btnRaporlar");
            btnRaporlar.ForeColor = Color.White;
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = SystemColors.Highlight;
            btnAnasayfa.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAnasayfa, "btnAnasayfa");
            btnAnasayfa.ForeColor = Color.White;
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.UseVisualStyleBackColor = false;
            // 
            // btnMaasHesaplama
            // 
            btnMaasHesaplama.BackColor = Color.FromArgb(45, 45, 45);
            btnMaasHesaplama.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnMaasHesaplama, "btnMaasHesaplama");
            btnMaasHesaplama.ForeColor = Color.White;
            btnMaasHesaplama.Name = "btnMaasHesaplama";
            btnMaasHesaplama.UseVisualStyleBackColor = false;
            // 
            // btnPersonelListesi
            // 
            btnPersonelListesi.BackColor = Color.FromArgb(45, 45, 45);
            btnPersonelListesi.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnPersonelListesi, "btnPersonelListesi");
            btnPersonelListesi.ForeColor = Color.White;
            btnPersonelListesi.Name = "btnPersonelListesi";
            btnPersonelListesi.UseVisualStyleBackColor = false;
            // 
            // pnlAnasayfa
            // 
            pnlAnasayfa.Controls.Add(pnlPersonelListesi);
            pnlAnasayfa.Controls.Add(pnlSonIslemler);
            pnlAnasayfa.Controls.Add(pnlKart4);
            pnlAnasayfa.Controls.Add(pnlKart3);
            pnlAnasayfa.Controls.Add(pnlKart2);
            pnlAnasayfa.Controls.Add(pnlKart1);
            resources.ApplyResources(pnlAnasayfa, "pnlAnasayfa");
            pnlAnasayfa.Name = "pnlAnasayfa";
            // 
            // pnlSonIslemler
            // 
            pnlSonIslemler.BackColor = Color.FromArgb(45, 45, 45);
            pnlSonIslemler.Controls.Add(dgvSonIslemler);
            pnlSonIslemler.Controls.Add(lblSonIslemlerBaslik);
            resources.ApplyResources(pnlSonIslemler, "pnlSonIslemler");
            pnlSonIslemler.Name = "pnlSonIslemler";
            // 
            // dgvSonIslemler
            // 
            dgvSonIslemler.BackgroundColor = Color.FromArgb(51, 51, 51);
            dgvSonIslemler.BorderStyle = BorderStyle.None;
            dgvSonIslemler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSonIslemler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSonIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSonIslemler.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSonIslemler.GridColor = Color.FromArgb(85, 85, 85);
            resources.ApplyResources(dgvSonIslemler, "dgvSonIslemler");
            dgvSonIslemler.Name = "dgvSonIslemler";
            dgvSonIslemler.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvSonIslemler.RowHeadersVisible = false;
            // 
            // lblSonIslemlerBaslik
            // 
            resources.ApplyResources(lblSonIslemlerBaslik, "lblSonIslemlerBaslik");
            lblSonIslemlerBaslik.ForeColor = Color.White;
            lblSonIslemlerBaslik.Name = "lblSonIslemlerBaslik";
            // 
            // pnlKart4
            // 
            pnlKart4.BackColor = Color.FromArgb(45, 45, 45);
            pnlKart4.Controls.Add(label1);
            resources.ApplyResources(pnlKart4, "pnlKart4");
            pnlKart4.Name = "pnlKart4";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // pnlKart3
            // 
            pnlKart3.BackColor = Color.FromArgb(45, 45, 45);
            pnlKart3.Controls.Add(label3);
            resources.ApplyResources(pnlKart3, "pnlKart3");
            pnlKart3.Name = "pnlKart3";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // pnlKart2
            // 
            pnlKart2.BackColor = Color.FromArgb(45, 45, 45);
            pnlKart2.Controls.Add(lbl);
            resources.ApplyResources(pnlKart2, "pnlKart2");
            pnlKart2.Name = "pnlKart2";
            // 
            // lbl
            // 
            resources.ApplyResources(lbl, "lbl");
            lbl.ForeColor = Color.White;
            lbl.Name = "lbl";
            // 
            // pnlKart1
            // 
            pnlKart1.BackColor = Color.FromArgb(45, 45, 45);
            pnlKart1.Controls.Add(lblKart1Deger);
            pnlKart1.Controls.Add(lblKart1Baslik);
            resources.ApplyResources(pnlKart1, "pnlKart1");
            pnlKart1.Name = "pnlKart1";
            // 
            // lblKart1Deger
            // 
            resources.ApplyResources(lblKart1Deger, "lblKart1Deger");
            lblKart1Deger.ForeColor = SystemColors.Highlight;
            lblKart1Deger.Name = "lblKart1Deger";
            // 
            // lblKart1Baslik
            // 
            resources.ApplyResources(lblKart1Baslik, "lblKart1Baslik");
            lblKart1Baslik.ForeColor = Color.White;
            lblKart1Baslik.Name = "lblKart1Baslik";
            // 
            // pnlPersonelListesi
            // 
            resources.ApplyResources(pnlPersonelListesi, "pnlPersonelListesi");
            pnlPersonelListesi.Name = "pnlPersonelListesi";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            Controls.Add(pnlAnasayfa);
            Controls.Add(pnlMenu);
            Controls.Add(pnlBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            pnlBaslik.ResumeLayout(false);
            pnlBaslik.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlAnasayfa.ResumeLayout(false);
            pnlSonIslemler.ResumeLayout(false);
            pnlSonIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSonIslemler).EndInit();
            pnlKart4.ResumeLayout(false);
            pnlKart4.PerformLayout();
            pnlKart3.ResumeLayout(false);
            pnlKart3.PerformLayout();
            pnlKart2.ResumeLayout(false);
            pnlKart2.PerformLayout();
            pnlKart1.ResumeLayout(false);
            pnlKart1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBaslik;
        private Label lblBaslik;
        private Panel pnlMenu;
        private Button btnAnasayfa;
        private Button btnRaporlar;
        private Button btnMaasHesaplama;
        private Button btnPersonelListesi;
        private Panel pnlAnasayfa;
        private Panel pnlKart4;
        private Panel pnlKart3;
        private Panel pnlKart2;
        private Panel pnlKart1;
        private Label lblKart1Baslik;
        private Label label3;
        private Label lbl;
        private Label lblKart1Deger;
        private Label label1;
        private Panel pnlSonIslemler;
        private DataGridView dgvSonIslemler;
        private Label lblSonIslemlerBaslik;
        private Panel pnlPersonelListesi;
    }
}
