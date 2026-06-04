namespace HaliSahaRezervasyonOtomasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrAnimasyon = new System.Windows.Forms.Timer(this.components);
            this.lblAnimasyon = new System.Windows.Forms.Label();
            this.picMusteriAnim = new System.Windows.Forms.PictureBox();
            this.picSahaAnim = new System.Windows.Forms.PictureBox();
            this.picRezervasyonAnim = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMusteri = new System.Windows.Forms.TabPage();
            this.grpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.grpMusteriIslemler = new System.Windows.Forms.GroupBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriTemizle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.tabSaha = new System.Windows.Forms.TabPage();
            this.grpSahaBilgileri = new System.Windows.Forms.GroupBox();
            this.lblSahaAdi = new System.Windows.Forms.Label();
            this.txtSahaAdi = new System.Windows.Forms.TextBox();
            this.lblSahaTuru = new System.Windows.Forms.Label();
            this.cmbSahaTuru = new System.Windows.Forms.ComboBox();
            this.lblSaatlikUcret = new System.Windows.Forms.Label();
            this.txtSaatlikUcret = new System.Windows.Forms.TextBox();
            this.grpSahaIslemler = new System.Windows.Forms.GroupBox();
            this.btnSahaEkle = new System.Windows.Forms.Button();
            this.btnSahaGuncelle = new System.Windows.Forms.Button();
            this.btnSahaSil = new System.Windows.Forms.Button();
            this.btnSahaTemizle = new System.Windows.Forms.Button();
            this.btnSahaListele = new System.Windows.Forms.Button();
            this.dgvSahalar = new System.Windows.Forms.DataGridView();
            this.tabRezervasyon = new System.Windows.Forms.TabPage();
            this.grpRezervasyonBilgileri = new System.Windows.Forms.GroupBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblSaha = new System.Windows.Forms.Label();
            this.cmbSaha = new System.Windows.Forms.ComboBox();
            this.lblMacTarihi = new System.Windows.Forms.Label();
            this.dtpMacTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblMacSaati = new System.Windows.Forms.Label();
            this.cmbMacSaati = new System.Windows.Forms.ComboBox();
            this.grpRezervasyonIslemler = new System.Windows.Forms.GroupBox();
            this.btnRezervasyonEkle = new System.Windows.Forms.Button();
            this.btnRezervasyonSil = new System.Windows.Forms.Button();
            this.btnRezervasyonListele = new System.Windows.Forms.Button();
            this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.tabLinq = new System.Windows.Forms.TabPage();
            this.grpSorguSecimi = new System.Windows.Forms.GroupBox();
            this.rbSorgu1 = new System.Windows.Forms.RadioButton();
            this.rbSorgu2 = new System.Windows.Forms.RadioButton();
            this.btnSorguCalistir = new System.Windows.Forms.Button();
            this.grpSorguSonuc = new System.Windows.Forms.GroupBox();
            this.pnlSorguSonuc = new System.Windows.Forms.Panel();
            this.lblSorguSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMusteriAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSahaAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRezervasyonAnim)).BeginInit();
            this.lblBaslik.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMusteri.SuspendLayout();
            this.grpMusteriBilgileri.SuspendLayout();
            this.grpMusteriIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.tabSaha.SuspendLayout();
            this.grpSahaBilgileri.SuspendLayout();
            this.grpSahaIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSahalar)).BeginInit();
            this.tabRezervasyon.SuspendLayout();
            this.grpRezervasyonBilgileri.SuspendLayout();
            this.grpRezervasyonIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            this.tabLinq.SuspendLayout();
            this.grpSorguSecimi.SuspendLayout();
            this.grpSorguSonuc.SuspendLayout();
            this.pnlSorguSonuc.SuspendLayout();
            this.SuspendLayout();

            this.tmrAnimasyon.Enabled = true;
            this.tmrAnimasyon.Interval = 25;
            this.tmrAnimasyon.Tick += new System.EventHandler(this.tmrAnimasyon_Tick);

            this.lblAnimasyon.AutoSize = true;
            this.lblAnimasyon.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimasyon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblAnimasyon.ForeColor = System.Drawing.Color.White;
            this.lblAnimasyon.Location = new System.Drawing.Point(-75, 2);
            this.lblAnimasyon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimasyon.Name = "lblAnimasyon";
            this.lblAnimasyon.Size = new System.Drawing.Size(112, 37);
            this.lblAnimasyon.TabIndex = 99;
            this.lblAnimasyon.Text = "🏃‍♂️   ⚽";

            this.picMusteriAnim.BackColor = System.Drawing.Color.Transparent;
            this.picMusteriAnim.Location = new System.Drawing.Point(15, 341);
            this.picMusteriAnim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picMusteriAnim.Name = "picMusteriAnim";
            this.picMusteriAnim.Size = new System.Drawing.Size(355, 191);
            this.picMusteriAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMusteriAnim.TabIndex = 100;
            this.picMusteriAnim.TabStop = false;

            this.picSahaAnim.BackColor = System.Drawing.Color.Transparent;
            this.picSahaAnim.Location = new System.Drawing.Point(15, 341);
            this.picSahaAnim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSahaAnim.Name = "picSahaAnim";
            this.picSahaAnim.Size = new System.Drawing.Size(355, 191);
            this.picSahaAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSahaAnim.TabIndex = 100;
            this.picSahaAnim.TabStop = false;

            this.picRezervasyonAnim.BackColor = System.Drawing.Color.Transparent;
            this.picRezervasyonAnim.Location = new System.Drawing.Point(15, 345);
            this.picRezervasyonAnim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picRezervasyonAnim.Name = "picRezervasyonAnim";
            this.picRezervasyonAnim.Size = new System.Drawing.Size(355, 187);
            this.picRezervasyonAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRezervasyonAnim.TabIndex = 100;
            this.picRezervasyonAnim.TabStop = false;

            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.lblBaslik.Controls.Add(this.lblAnimasyon);
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1130, 55);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "⚽  HALI SAHA REZERVASYON OTOMASYONU";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.tabControl.Controls.Add(this.tabMusteri);
            this.tabControl.Controls.Add(this.tabSaha);
            this.tabControl.Controls.Add(this.tabRezervasyon);
            this.tabControl.Controls.Add(this.tabLinq);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1130, 585);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);

            this.tabMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.tabMusteri.Controls.Add(this.picMusteriAnim);
            this.tabMusteri.Controls.Add(this.grpMusteriBilgileri);
            this.tabMusteri.Controls.Add(this.grpMusteriIslemler);
            this.tabMusteri.Controls.Add(this.dgvMusteriler);
            this.tabMusteri.Location = new System.Drawing.Point(4, 32);
            this.tabMusteri.Name = "tabMusteri";
            this.tabMusteri.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMusteri.Size = new System.Drawing.Size(1122, 549);
            this.tabMusteri.TabIndex = 0;
            this.tabMusteri.Text = "  Müşteri İşlemleri  ";

            this.grpMusteriBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpMusteriBilgileri.Controls.Add(this.lblAd);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriAd);
            this.grpMusteriBilgileri.Controls.Add(this.lblSoyad);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriSoyad);
            this.grpMusteriBilgileri.Controls.Add(this.lblTelefon);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriTelefon);
            this.grpMusteriBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMusteriBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpMusteriBilgileri.Location = new System.Drawing.Point(15, 12);
            this.grpMusteriBilgileri.Name = "grpMusteriBilgileri";
            this.grpMusteriBilgileri.Size = new System.Drawing.Size(355, 185);
            this.grpMusteriBilgileri.TabIndex = 0;
            this.grpMusteriBilgileri.TabStop = false;
            this.grpMusteriBilgileri.Text = "Müşteri Bilgileri";

            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblAd.Location = new System.Drawing.Point(15, 35);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(80, 23);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtMusteriAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.txtMusteriAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriAd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMusteriAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtMusteriAd.Location = new System.Drawing.Point(100, 33);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(235, 30);
            this.txtMusteriAd.TabIndex = 1;

            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblSoyad.Location = new System.Drawing.Point(15, 75);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(80, 23);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtMusteriSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.txtMusteriSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriSoyad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMusteriSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtMusteriSoyad.Location = new System.Drawing.Point(100, 73);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(235, 30);
            this.txtMusteriSoyad.TabIndex = 3;

            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblTelefon.Location = new System.Drawing.Point(15, 115);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(80, 23);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon:";
            this.lblTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtMusteriTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.txtMusteriTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriTelefon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMusteriTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtMusteriTelefon.Location = new System.Drawing.Point(100, 113);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(235, 30);
            this.txtMusteriTelefon.TabIndex = 5;

            this.grpMusteriIslemler.BackColor = System.Drawing.Color.Transparent;
            this.grpMusteriIslemler.Controls.Add(this.btnMusteriEkle);
            this.grpMusteriIslemler.Controls.Add(this.btnMusteriGuncelle);
            this.grpMusteriIslemler.Controls.Add(this.btnMusteriSil);
            this.grpMusteriIslemler.Controls.Add(this.btnMusteriTemizle);
            this.grpMusteriIslemler.Controls.Add(this.btnMusteriListele);
            this.grpMusteriIslemler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMusteriIslemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpMusteriIslemler.Location = new System.Drawing.Point(15, 210);
            this.grpMusteriIslemler.Name = "grpMusteriIslemler";
            this.grpMusteriIslemler.Size = new System.Drawing.Size(355, 120);
            this.grpMusteriIslemler.TabIndex = 1;
            this.grpMusteriIslemler.TabStop = false;
            this.grpMusteriIslemler.Text = "İşlemler";

            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnMusteriEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 30);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(105, 35);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "➕ Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);

            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnMusteriGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriGuncelle.FlatAppearance.BorderSize = 0;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMusteriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(125, 30);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(105, 35);
            this.btnMusteriGuncelle.TabIndex = 1;
            this.btnMusteriGuncelle.Text = "✏️ Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);

            this.btnMusteriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMusteriSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriSil.FlatAppearance.BorderSize = 0;
            this.btnMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMusteriSil.ForeColor = System.Drawing.Color.White;
            this.btnMusteriSil.Location = new System.Drawing.Point(238, 30);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(105, 35);
            this.btnMusteriSil.TabIndex = 2;
            this.btnMusteriSil.Text = "🗑️ Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);

            this.btnMusteriTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnMusteriTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriTemizle.FlatAppearance.BorderSize = 0;
            this.btnMusteriTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMusteriTemizle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriTemizle.Location = new System.Drawing.Point(12, 73);
            this.btnMusteriTemizle.Name = "btnMusteriTemizle";
            this.btnMusteriTemizle.Size = new System.Drawing.Size(105, 35);
            this.btnMusteriTemizle.TabIndex = 3;
            this.btnMusteriTemizle.Text = "🔄 Temizle";
            this.btnMusteriTemizle.UseVisualStyleBackColor = false;
            this.btnMusteriTemizle.Click += new System.EventHandler(this.btnMusteriTemizle_Click);

            this.btnMusteriListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMusteriListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriListele.FlatAppearance.BorderSize = 0;
            this.btnMusteriListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMusteriListele.ForeColor = System.Drawing.Color.White;
            this.btnMusteriListele.Location = new System.Drawing.Point(125, 73);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(105, 35);
            this.btnMusteriListele.TabIndex = 4;
            this.btnMusteriListele.Text = "📋 Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);

            this.dgvMusteriler.AllowUserToAddRows = false;
            this.dgvMusteriler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.dgvMusteriler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.dgvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMusteriler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMusteriler.ColumnHeadersHeight = 40;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMusteriler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMusteriler.EnableHeadersVisualStyles = false;
            this.dgvMusteriler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.dgvMusteriler.Location = new System.Drawing.Point(382, 16);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.ReadOnly = true;
            this.dgvMusteriler.RowHeadersVisible = false;
            this.dgvMusteriler.RowHeadersWidth = 51;
            this.dgvMusteriler.RowTemplate.Height = 35;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(724, 314);
            this.dgvMusteriler.TabIndex = 2;
            this.dgvMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriler_CellClick);

            this.tabSaha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.tabSaha.Controls.Add(this.picSahaAnim);
            this.tabSaha.Controls.Add(this.grpSahaBilgileri);
            this.tabSaha.Controls.Add(this.grpSahaIslemler);
            this.tabSaha.Controls.Add(this.dgvSahalar);
            this.tabSaha.Location = new System.Drawing.Point(4, 32);
            this.tabSaha.Name = "tabSaha";
            this.tabSaha.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabSaha.Size = new System.Drawing.Size(1122, 549);
            this.tabSaha.TabIndex = 1;
            this.tabSaha.Text = "  Saha İşlemleri  ";

            this.grpSahaBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpSahaBilgileri.Controls.Add(this.lblSahaAdi);
            this.grpSahaBilgileri.Controls.Add(this.txtSahaAdi);
            this.grpSahaBilgileri.Controls.Add(this.lblSahaTuru);
            this.grpSahaBilgileri.Controls.Add(this.cmbSahaTuru);
            this.grpSahaBilgileri.Controls.Add(this.lblSaatlikUcret);
            this.grpSahaBilgileri.Controls.Add(this.txtSaatlikUcret);
            this.grpSahaBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSahaBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpSahaBilgileri.Location = new System.Drawing.Point(15, 12);
            this.grpSahaBilgileri.Name = "grpSahaBilgileri";
            this.grpSahaBilgileri.Size = new System.Drawing.Size(355, 185);
            this.grpSahaBilgileri.TabIndex = 0;
            this.grpSahaBilgileri.TabStop = false;
            this.grpSahaBilgileri.Text = "Saha Bilgileri";

            this.lblSahaAdi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSahaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblSahaAdi.Location = new System.Drawing.Point(15, 35);
            this.lblSahaAdi.Name = "lblSahaAdi";
            this.lblSahaAdi.Size = new System.Drawing.Size(80, 23);
            this.lblSahaAdi.TabIndex = 0;
            this.lblSahaAdi.Text = "Saha Adı:";
            this.lblSahaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtSahaAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.txtSahaAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSahaAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSahaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtSahaAdi.Location = new System.Drawing.Point(100, 33);
            this.txtSahaAdi.Name = "txtSahaAdi";
            this.txtSahaAdi.Size = new System.Drawing.Size(235, 30);
            this.txtSahaAdi.TabIndex = 1;

            this.lblSahaTuru.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSahaTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblSahaTuru.Location = new System.Drawing.Point(15, 75);
            this.lblSahaTuru.Name = "lblSahaTuru";
            this.lblSahaTuru.Size = new System.Drawing.Size(80, 23);
            this.lblSahaTuru.TabIndex = 2;
            this.lblSahaTuru.Text = "Saha Türü:";
            this.lblSahaTuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cmbSahaTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.cmbSahaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSahaTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSahaTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSahaTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.cmbSahaTuru.Items.AddRange(new object[] {
            "Açık",
            "Kapalı"});
            this.cmbSahaTuru.Location = new System.Drawing.Point(100, 73);
            this.cmbSahaTuru.Name = "cmbSahaTuru";
            this.cmbSahaTuru.Size = new System.Drawing.Size(235, 31);
            this.cmbSahaTuru.TabIndex = 3;

            this.lblSaatlikUcret.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSaatlikUcret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblSaatlikUcret.Location = new System.Drawing.Point(15, 115);
            this.lblSaatlikUcret.Name = "lblSaatlikUcret";
            this.lblSaatlikUcret.Size = new System.Drawing.Size(80, 23);
            this.lblSaatlikUcret.TabIndex = 4;
            this.lblSaatlikUcret.Text = "Ücret (TL):";
            this.lblSaatlikUcret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtSaatlikUcret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.txtSaatlikUcret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaatlikUcret.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSaatlikUcret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtSaatlikUcret.Location = new System.Drawing.Point(100, 113);
            this.txtSaatlikUcret.Name = "txtSaatlikUcret";
            this.txtSaatlikUcret.Size = new System.Drawing.Size(235, 30);
            this.txtSaatlikUcret.TabIndex = 5;

            this.grpSahaIslemler.BackColor = System.Drawing.Color.Transparent;
            this.grpSahaIslemler.Controls.Add(this.btnSahaEkle);
            this.grpSahaIslemler.Controls.Add(this.btnSahaGuncelle);
            this.grpSahaIslemler.Controls.Add(this.btnSahaSil);
            this.grpSahaIslemler.Controls.Add(this.btnSahaTemizle);
            this.grpSahaIslemler.Controls.Add(this.btnSahaListele);
            this.grpSahaIslemler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSahaIslemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpSahaIslemler.Location = new System.Drawing.Point(15, 210);
            this.grpSahaIslemler.Name = "grpSahaIslemler";
            this.grpSahaIslemler.Size = new System.Drawing.Size(355, 120);
            this.grpSahaIslemler.TabIndex = 1;
            this.grpSahaIslemler.TabStop = false;
            this.grpSahaIslemler.Text = "İşlemler";

            this.btnSahaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSahaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSahaEkle.FlatAppearance.BorderSize = 0;
            this.btnSahaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSahaEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSahaEkle.ForeColor = System.Drawing.Color.White;
            this.btnSahaEkle.Location = new System.Drawing.Point(12, 30);
            this.btnSahaEkle.Name = "btnSahaEkle";
            this.btnSahaEkle.Size = new System.Drawing.Size(105, 35);
            this.btnSahaEkle.TabIndex = 0;
            this.btnSahaEkle.Text = "➕ Ekle";
            this.btnSahaEkle.UseVisualStyleBackColor = false;
            this.btnSahaEkle.Click += new System.EventHandler(this.btnSahaEkle_Click);

            this.btnSahaGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSahaGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSahaGuncelle.FlatAppearance.BorderSize = 0;
            this.btnSahaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSahaGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSahaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnSahaGuncelle.Location = new System.Drawing.Point(125, 30);
            this.btnSahaGuncelle.Name = "btnSahaGuncelle";
            this.btnSahaGuncelle.Size = new System.Drawing.Size(105, 35);
            this.btnSahaGuncelle.TabIndex = 1;
            this.btnSahaGuncelle.Text = "✏️ Güncelle";
            this.btnSahaGuncelle.UseVisualStyleBackColor = false;
            this.btnSahaGuncelle.Click += new System.EventHandler(this.btnSahaGuncelle_Click);

            this.btnSahaSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSahaSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSahaSil.FlatAppearance.BorderSize = 0;
            this.btnSahaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSahaSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSahaSil.ForeColor = System.Drawing.Color.White;
            this.btnSahaSil.Location = new System.Drawing.Point(238, 30);
            this.btnSahaSil.Name = "btnSahaSil";
            this.btnSahaSil.Size = new System.Drawing.Size(105, 35);
            this.btnSahaSil.TabIndex = 2;
            this.btnSahaSil.Text = "🗑️ Sil";
            this.btnSahaSil.UseVisualStyleBackColor = false;
            this.btnSahaSil.Click += new System.EventHandler(this.btnSahaSil_Click);

            this.btnSahaTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnSahaTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSahaTemizle.FlatAppearance.BorderSize = 0;
            this.btnSahaTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSahaTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSahaTemizle.ForeColor = System.Drawing.Color.White;
            this.btnSahaTemizle.Location = new System.Drawing.Point(12, 73);
            this.btnSahaTemizle.Name = "btnSahaTemizle";
            this.btnSahaTemizle.Size = new System.Drawing.Size(105, 35);
            this.btnSahaTemizle.TabIndex = 3;
            this.btnSahaTemizle.Text = "🔄 Temizle";
            this.btnSahaTemizle.UseVisualStyleBackColor = false;
            this.btnSahaTemizle.Click += new System.EventHandler(this.btnSahaTemizle_Click);

            this.btnSahaListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSahaListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSahaListele.FlatAppearance.BorderSize = 0;
            this.btnSahaListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSahaListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSahaListele.ForeColor = System.Drawing.Color.White;
            this.btnSahaListele.Location = new System.Drawing.Point(125, 73);
            this.btnSahaListele.Name = "btnSahaListele";
            this.btnSahaListele.Size = new System.Drawing.Size(105, 35);
            this.btnSahaListele.TabIndex = 4;
            this.btnSahaListele.Text = "📋 Listele";
            this.btnSahaListele.UseVisualStyleBackColor = false;
            this.btnSahaListele.Click += new System.EventHandler(this.btnSahaListele_Click);

            this.dgvSahalar.AllowUserToAddRows = false;
            this.dgvSahalar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.dgvSahalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSahalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSahalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSahalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.dgvSahalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSahalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSahalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSahalar.ColumnHeadersHeight = 40;
            this.dgvSahalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSahalar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSahalar.EnableHeadersVisualStyles = false;
            this.dgvSahalar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.dgvSahalar.Location = new System.Drawing.Point(382, 16);
            this.dgvSahalar.Name = "dgvSahalar";
            this.dgvSahalar.ReadOnly = true;
            this.dgvSahalar.RowHeadersVisible = false;
            this.dgvSahalar.RowHeadersWidth = 51;
            this.dgvSahalar.RowTemplate.Height = 35;
            this.dgvSahalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSahalar.Size = new System.Drawing.Size(724, 314);
            this.dgvSahalar.TabIndex = 2;
            this.dgvSahalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSahalar_CellClick);

            this.tabRezervasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.tabRezervasyon.Controls.Add(this.picRezervasyonAnim);
            this.tabRezervasyon.Controls.Add(this.grpRezervasyonBilgileri);
            this.tabRezervasyon.Controls.Add(this.grpRezervasyonIslemler);
            this.tabRezervasyon.Controls.Add(this.dgvRezervasyonlar);
            this.tabRezervasyon.Location = new System.Drawing.Point(4, 32);
            this.tabRezervasyon.Name = "tabRezervasyon";
            this.tabRezervasyon.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabRezervasyon.Size = new System.Drawing.Size(1122, 549);
            this.tabRezervasyon.TabIndex = 2;
            this.tabRezervasyon.Text = "  Rezervasyon İşlemleri  ";

            this.grpRezervasyonBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpRezervasyonBilgileri.Controls.Add(this.lblMusteri);
            this.grpRezervasyonBilgileri.Controls.Add(this.cmbMusteri);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblSaha);
            this.grpRezervasyonBilgileri.Controls.Add(this.cmbSaha);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblMacTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.dtpMacTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblMacSaati);
            this.grpRezervasyonBilgileri.Controls.Add(this.cmbMacSaati);
            this.grpRezervasyonBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRezervasyonBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpRezervasyonBilgileri.Location = new System.Drawing.Point(15, 12);
            this.grpRezervasyonBilgileri.Name = "grpRezervasyonBilgileri";
            this.grpRezervasyonBilgileri.Size = new System.Drawing.Size(355, 225);
            this.grpRezervasyonBilgileri.TabIndex = 0;
            this.grpRezervasyonBilgileri.TabStop = false;
            this.grpRezervasyonBilgileri.Text = "Rezervasyon Bilgileri";

            this.lblMusteri.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblMusteri.Location = new System.Drawing.Point(15, 35);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(80, 23);
            this.lblMusteri.TabIndex = 0;
            this.lblMusteri.Text = "Müşteri:";
            this.lblMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cmbMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMusteri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.cmbMusteri.Location = new System.Drawing.Point(100, 33);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(235, 31);
            this.cmbMusteri.TabIndex = 1;

            this.lblSaha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSaha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblSaha.Location = new System.Drawing.Point(15, 75);
            this.lblSaha.Name = "lblSaha";
            this.lblSaha.Size = new System.Drawing.Size(80, 23);
            this.lblSaha.TabIndex = 2;
            this.lblSaha.Text = "Saha:";
            this.lblSaha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cmbSaha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.cmbSaha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSaha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSaha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.cmbSaha.Location = new System.Drawing.Point(100, 73);
            this.cmbSaha.Name = "cmbSaha";
            this.cmbSaha.Size = new System.Drawing.Size(235, 31);
            this.cmbSaha.TabIndex = 3;

            this.lblMacTarihi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMacTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblMacTarihi.Location = new System.Drawing.Point(15, 115);
            this.lblMacTarihi.Name = "lblMacTarihi";
            this.lblMacTarihi.Size = new System.Drawing.Size(80, 23);
            this.lblMacTarihi.TabIndex = 4;
            this.lblMacTarihi.Text = "Maç Tarihi:";
            this.lblMacTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.dtpMacTarihi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.dtpMacTarihi.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.dtpMacTarihi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpMacTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMacTarihi.Location = new System.Drawing.Point(100, 113);
            this.dtpMacTarihi.Name = "dtpMacTarihi";
            this.dtpMacTarihi.Size = new System.Drawing.Size(235, 30);
            this.dtpMacTarihi.TabIndex = 5;

            this.lblMacSaati.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMacSaati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblMacSaati.Location = new System.Drawing.Point(15, 155);
            this.lblMacSaati.Name = "lblMacSaati";
            this.lblMacSaati.Size = new System.Drawing.Size(80, 23);
            this.lblMacSaati.TabIndex = 6;
            this.lblMacSaati.Text = "Maç Saati:";
            this.lblMacSaati.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cmbMacSaati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.cmbMacSaati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMacSaati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMacSaati.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMacSaati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.cmbMacSaati.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cmbMacSaati.Location = new System.Drawing.Point(100, 153);
            this.cmbMacSaati.Name = "cmbMacSaati";
            this.cmbMacSaati.Size = new System.Drawing.Size(235, 31);
            this.cmbMacSaati.TabIndex = 7;

            this.grpRezervasyonIslemler.BackColor = System.Drawing.Color.Transparent;
            this.grpRezervasyonIslemler.Controls.Add(this.btnRezervasyonEkle);
            this.grpRezervasyonIslemler.Controls.Add(this.btnRezervasyonSil);
            this.grpRezervasyonIslemler.Controls.Add(this.btnRezervasyonListele);
            this.grpRezervasyonIslemler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRezervasyonIslemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpRezervasyonIslemler.Location = new System.Drawing.Point(15, 248);
            this.grpRezervasyonIslemler.Name = "grpRezervasyonIslemler";
            this.grpRezervasyonIslemler.Size = new System.Drawing.Size(355, 85);
            this.grpRezervasyonIslemler.TabIndex = 1;
            this.grpRezervasyonIslemler.TabStop = false;
            this.grpRezervasyonIslemler.Text = "İşlemler";

            this.btnRezervasyonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRezervasyonEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyonEkle.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonEkle.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonEkle.Location = new System.Drawing.Point(12, 30);
            this.btnRezervasyonEkle.Name = "btnRezervasyonEkle";
            this.btnRezervasyonEkle.Size = new System.Drawing.Size(105, 40);
            this.btnRezervasyonEkle.TabIndex = 0;
            this.btnRezervasyonEkle.Text = "➕ Ekle";
            this.btnRezervasyonEkle.UseVisualStyleBackColor = false;
            this.btnRezervasyonEkle.Click += new System.EventHandler(this.btnRezervasyonEkle_Click);

            this.btnRezervasyonSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRezervasyonSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyonSil.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonSil.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonSil.Location = new System.Drawing.Point(125, 30);
            this.btnRezervasyonSil.Name = "btnRezervasyonSil";
            this.btnRezervasyonSil.Size = new System.Drawing.Size(105, 40);
            this.btnRezervasyonSil.TabIndex = 1;
            this.btnRezervasyonSil.Text = "🗑️ Sil";
            this.btnRezervasyonSil.UseVisualStyleBackColor = false;
            this.btnRezervasyonSil.Click += new System.EventHandler(this.btnRezervasyonSil_Click);

            this.btnRezervasyonListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRezervasyonListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyonListele.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonListele.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonListele.Location = new System.Drawing.Point(238, 30);
            this.btnRezervasyonListele.Name = "btnRezervasyonListele";
            this.btnRezervasyonListele.Size = new System.Drawing.Size(105, 40);
            this.btnRezervasyonListele.TabIndex = 2;
            this.btnRezervasyonListele.Text = "📋 Listele";
            this.btnRezervasyonListele.UseVisualStyleBackColor = false;
            this.btnRezervasyonListele.Click += new System.EventHandler(this.btnRezervasyonListele_Click);

            this.dgvRezervasyonlar.AllowUserToAddRows = false;
            this.dgvRezervasyonlar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.dgvRezervasyonlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRezervasyonlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRezervasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervasyonlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.dgvRezervasyonlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRezervasyonlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervasyonlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRezervasyonlar.ColumnHeadersHeight = 40;
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRezervasyonlar.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRezervasyonlar.EnableHeadersVisualStyles = false;
            this.dgvRezervasyonlar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(382, 16);
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            this.dgvRezervasyonlar.ReadOnly = true;
            this.dgvRezervasyonlar.RowHeadersVisible = false;
            this.dgvRezervasyonlar.RowHeadersWidth = 51;
            this.dgvRezervasyonlar.RowTemplate.Height = 35;
            this.dgvRezervasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(724, 317);
            this.dgvRezervasyonlar.TabIndex = 2;
            this.dgvRezervasyonlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervasyonlar_CellClick);

            this.tabLinq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.tabLinq.Controls.Add(this.grpSorguSecimi);
            this.tabLinq.Controls.Add(this.grpSorguSonuc);
            this.tabLinq.Location = new System.Drawing.Point(4, 32);
            this.tabLinq.Name = "tabLinq";
            this.tabLinq.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabLinq.Size = new System.Drawing.Size(1122, 549);
            this.tabLinq.TabIndex = 3;
            this.tabLinq.Text = "  LINQ Sorguları  ";

            this.grpSorguSecimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSorguSecimi.BackColor = System.Drawing.Color.Transparent;
            this.grpSorguSecimi.Controls.Add(this.rbSorgu1);
            this.grpSorguSecimi.Controls.Add(this.rbSorgu2);
            this.grpSorguSecimi.Controls.Add(this.btnSorguCalistir);
            this.grpSorguSecimi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSorguSecimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpSorguSecimi.Location = new System.Drawing.Point(15, 12);
            this.grpSorguSecimi.Name = "grpSorguSecimi";
            this.grpSorguSecimi.Size = new System.Drawing.Size(1090, 110);
            this.grpSorguSecimi.TabIndex = 0;
            this.grpSorguSecimi.TabStop = false;
            this.grpSorguSecimi.Text = "Sorgu Seçimi";

            this.rbSorgu1.Checked = true;
            this.rbSorgu1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbSorgu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.rbSorgu1.Location = new System.Drawing.Point(20, 32);
            this.rbSorgu1.Name = "rbSorgu1";
            this.rbSorgu1.Size = new System.Drawing.Size(700, 28);
            this.rbSorgu1.TabIndex = 0;
            this.rbSorgu1.TabStop = true;
            this.rbSorgu1.Text = "Saatlik ücreti 1500 TL\'den fazla olan sahaların rezervasyonlarını getir";

            this.rbSorgu2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbSorgu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.rbSorgu2.Location = new System.Drawing.Point(20, 66);
            this.rbSorgu2.Name = "rbSorgu2";
            this.rbSorgu2.Size = new System.Drawing.Size(700, 28);
            this.rbSorgu2.TabIndex = 1;
            this.rbSorgu2.Text = "Her müşterinin toplam rezervasyon sayısını ve harcadığı tutarı getir";

            this.btnSorguCalistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSorguCalistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorguCalistir.FlatAppearance.BorderSize = 0;
            this.btnSorguCalistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorguCalistir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSorguCalistir.ForeColor = System.Drawing.Color.White;
            this.btnSorguCalistir.Location = new System.Drawing.Point(750, 35);
            this.btnSorguCalistir.Name = "btnSorguCalistir";
            this.btnSorguCalistir.Size = new System.Drawing.Size(170, 50);
            this.btnSorguCalistir.TabIndex = 2;
            this.btnSorguCalistir.Text = "🔍 Sorguyu Çalıştır";
            this.btnSorguCalistir.UseVisualStyleBackColor = false;
            this.btnSorguCalistir.Click += new System.EventHandler(this.btnSorguCalistir_Click);

            this.grpSorguSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSorguSonuc.BackColor = System.Drawing.Color.Transparent;
            this.grpSorguSonuc.Controls.Add(this.pnlSorguSonuc);
            this.grpSorguSonuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSorguSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpSorguSonuc.Location = new System.Drawing.Point(15, 132);
            this.grpSorguSonuc.Name = "grpSorguSonuc";
            this.grpSorguSonuc.Size = new System.Drawing.Size(1090, 400);
            this.grpSorguSonuc.TabIndex = 1;
            this.grpSorguSonuc.TabStop = false;
            this.grpSorguSonuc.Text = "Sorgu Sonuçları";

            this.pnlSorguSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSorguSonuc.AutoScroll = true;
            this.pnlSorguSonuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.pnlSorguSonuc.Controls.Add(this.lblSorguSonuc);
            this.pnlSorguSonuc.Location = new System.Drawing.Point(10, 25);
            this.pnlSorguSonuc.Name = "pnlSorguSonuc";
            this.pnlSorguSonuc.Size = new System.Drawing.Size(1059, 365);
            this.pnlSorguSonuc.TabIndex = 0;

            this.lblSorguSonuc.AutoSize = true;
            this.lblSorguSonuc.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblSorguSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.lblSorguSonuc.Location = new System.Drawing.Point(15, 15);
            this.lblSorguSonuc.MaximumSize = new System.Drawing.Size(1030, 0);
            this.lblSorguSonuc.Name = "lblSorguSonuc";
            this.lblSorguSonuc.Size = new System.Drawing.Size(640, 44);
            this.lblSorguSonuc.TabIndex = 0;
            this.lblSorguSonuc.Text = "Sorgu sonuçları burada görüntülenecektir.\nYukarıdan bir sorgu seçip \'Sorguyu Çalı" +
    "ştır\' butonuna tıklayın.";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1130, 640);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblBaslik);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halı Saha Rezervasyon Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMusteriAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSahaAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRezervasyonAnim)).EndInit();
            this.lblBaslik.ResumeLayout(false);
            this.lblBaslik.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMusteri.ResumeLayout(false);
            this.grpMusteriBilgileri.ResumeLayout(false);
            this.grpMusteriBilgileri.PerformLayout();
            this.grpMusteriIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.tabSaha.ResumeLayout(false);
            this.grpSahaBilgileri.ResumeLayout(false);
            this.grpSahaBilgileri.PerformLayout();
            this.grpSahaIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSahalar)).EndInit();
            this.tabRezervasyon.ResumeLayout(false);
            this.grpRezervasyonBilgileri.ResumeLayout(false);
            this.grpRezervasyonIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            this.tabLinq.ResumeLayout(false);
            this.grpSorguSecimi.ResumeLayout(false);
            this.grpSorguSonuc.ResumeLayout(false);
            this.pnlSorguSonuc.ResumeLayout(false);
            this.pnlSorguSonuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMusteri;
        private System.Windows.Forms.TabPage tabSaha;
        private System.Windows.Forms.TabPage tabRezervasyon;
        private System.Windows.Forms.TabPage tabLinq;

        private System.Windows.Forms.GroupBox grpMusteriBilgileri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.GroupBox grpMusteriIslemler;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriTemizle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.DataGridView dgvMusteriler;

        private System.Windows.Forms.GroupBox grpSahaBilgileri;
        private System.Windows.Forms.Label lblSahaAdi;
        private System.Windows.Forms.TextBox txtSahaAdi;
        private System.Windows.Forms.Label lblSahaTuru;
        private System.Windows.Forms.ComboBox cmbSahaTuru;
        private System.Windows.Forms.Label lblSaatlikUcret;
        private System.Windows.Forms.TextBox txtSaatlikUcret;
        private System.Windows.Forms.GroupBox grpSahaIslemler;
        private System.Windows.Forms.Button btnSahaEkle;
        private System.Windows.Forms.Button btnSahaGuncelle;
        private System.Windows.Forms.Button btnSahaSil;
        private System.Windows.Forms.Button btnSahaTemizle;
        private System.Windows.Forms.Button btnSahaListele;
        private System.Windows.Forms.DataGridView dgvSahalar;

        private System.Windows.Forms.GroupBox grpRezervasyonBilgileri;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label lblSaha;
        private System.Windows.Forms.ComboBox cmbSaha;
        private System.Windows.Forms.Label lblMacTarihi;
        private System.Windows.Forms.DateTimePicker dtpMacTarihi;
        private System.Windows.Forms.Label lblMacSaati;
        private System.Windows.Forms.ComboBox cmbMacSaati;
        private System.Windows.Forms.GroupBox grpRezervasyonIslemler;
        private System.Windows.Forms.Button btnRezervasyonEkle;
        private System.Windows.Forms.Button btnRezervasyonSil;
        private System.Windows.Forms.Button btnRezervasyonListele;
        private System.Windows.Forms.DataGridView dgvRezervasyonlar;

        private System.Windows.Forms.GroupBox grpSorguSecimi;
        private System.Windows.Forms.RadioButton rbSorgu1;
        private System.Windows.Forms.RadioButton rbSorgu2;
        private System.Windows.Forms.Button btnSorguCalistir;
        private System.Windows.Forms.GroupBox grpSorguSonuc;
        private System.Windows.Forms.Panel pnlSorguSonuc;
        private System.Windows.Forms.Label lblSorguSonuc;

        private System.Windows.Forms.Timer tmrAnimasyon;
        private System.Windows.Forms.Label lblAnimasyon;
        private System.Windows.Forms.PictureBox picMusteriAnim;
        private System.Windows.Forms.PictureBox picSahaAnim;
        private System.Windows.Forms.PictureBox picRezervasyonAnim;
    }
}
