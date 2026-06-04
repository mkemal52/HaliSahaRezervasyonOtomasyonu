using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HaliSahaRezervasyonOtomasyonu.Models;

namespace HaliSahaRezervasyonOtomasyonu
{
    public partial class Form1 : Form
    {
        private int seciliMusteriID = 0;
        private int seciliSahaID = 0;
        private int seciliRezervasyonID = 0;
        private Image animImage = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession) return;
            System.Reflection.PropertyInfo aProp = typeof(Control).GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            if (aProp != null) aProp.SetValue(c, true, null);
        }

        private void tmrAnimasyon_Tick(object sender, EventArgs e)
        {
            lblAnimasyon.Left += 3;

            if (lblAnimasyon.Left > this.Width)
            {
                lblAnimasyon.Left = -100;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetDoubleBuffered(this);
                SetDoubleBuffered(tabControl);
                SetDoubleBuffered(tabMusteri);
                SetDoubleBuffered(tabSaha);
                SetDoubleBuffered(tabRezervasyon);
                SetDoubleBuffered(tabLinq);
                SetDoubleBuffered(dgvMusteriler);
                SetDoubleBuffered(dgvSahalar);
                SetDoubleBuffered(dgvRezervasyonlar);
            }
            catch { }

            try
            {
                string imgPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "soccer_field_bg.png");
                if (System.IO.File.Exists(imgPath))
                {
                    var bgImage = System.Drawing.Image.FromFile(imgPath);
                    tabMusteri.BackgroundImage = bgImage;
                    tabMusteri.BackgroundImageLayout = ImageLayout.Stretch;
                    tabSaha.BackgroundImage = bgImage;
                    tabSaha.BackgroundImageLayout = ImageLayout.Stretch;
                    tabRezervasyon.BackgroundImage = bgImage;
                    tabRezervasyon.BackgroundImageLayout = ImageLayout.Stretch;
                    tabLinq.BackgroundImage = bgImage;
                    tabLinq.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch { }

            try
            {
                string animPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "soccer_anim.gif");
                if (System.IO.File.Exists(animPath))
                {
                    animImage = System.Drawing.Image.FromFile(animPath);
                    UpdateTabAnimations();
                }
            }
            catch { }

            MusterileriListele();
            SahalariListele();
            RezervasyonlariListele();
            ComboBoxlariDoldur();
        }

        private void UpdateTabAnimations()
        {
            if (animImage == null) return;
            picMusteriAnim.Image = (tabControl.SelectedTab == tabMusteri) ? animImage : null;
            picSahaAnim.Image = (tabControl.SelectedTab == tabSaha) ? animImage : null;
            picRezervasyonAnim.Image = (tabControl.SelectedTab == tabRezervasyon) ? animImage : null;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTabAnimations();
        }

        private void ComboBoxlariDoldur()
        {
            using (var db = new ContextDb())
            {
                var musteriler = db.Musteriler.Select(m => new
                {
                    m.MusteriID,
                    AdSoyad = m.Ad + " " + m.Soyad
                }).ToList();
                cmbMusteri.DataSource = musteriler;
                cmbMusteri.DisplayMember = "AdSoyad";
                cmbMusteri.ValueMember = "MusteriID";

                var sahalar = db.Sahalar.Select(s => new
                {
                    s.SahaID,
                    SahaBilgi = s.SahaAdi + " (" + s.SahaTuru + " - " + s.SaatlikUcret + " TL)"
                }).ToList();
                cmbSaha.DataSource = sahalar;
                cmbSaha.DisplayMember = "SahaBilgi";
                cmbSaha.ValueMember = "SahaID";
            }
        }

        private void MusteriAlanlariTemizle()
        {
            txtMusteriAd.Text = "";
            txtMusteriSoyad.Text = "";
            txtMusteriTelefon.Text = "";
            seciliMusteriID = 0;
        }

        private void SahaAlanlariTemizle()
        {
            txtSahaAdi.Text = "";
            cmbSahaTuru.SelectedIndex = -1;
            txtSaatlikUcret.Text = "";
            seciliSahaID = 0;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) ||
                string.IsNullOrWhiteSpace(txtMusteriSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtMusteriTelefon.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var db = new ContextDb())
                {
                    var yeniMusteri = new Musteri
                    {
                        Ad = txtMusteriAd.Text.Trim(),
                        Soyad = txtMusteriSoyad.Text.Trim(),
                        Telefon = txtMusteriTelefon.Text.Trim()
                    };
                    db.Musteriler.Add(yeniMusteri);
                    db.SaveChanges();
                    MessageBox.Show("Müşteri başarıyla eklendi!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MusterileriListele();
                    ComboBoxlariDoldur();
                    MusteriAlanlariTemizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (seciliMusteriID == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşteriyi tablodan seçiniz!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sonuc = MessageBox.Show(
                "Bu müşteriyi ve ona ait tüm rezervasyonları silmek istediğinize emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    using (var db = new ContextDb())
                    {
                        var musteriRezervasyonlari = db.Rezervasyonlar
                            .Where(r => r.MusteriID == seciliMusteriID).ToList();
                        foreach (var rez in musteriRezervasyonlari)
                            db.Rezervasyonlar.Remove(rez);

                        var musteri = db.Musteriler.Find(seciliMusteriID);
                        if (musteri != null)
                        {
                            db.Musteriler.Remove(musteri);
                            db.SaveChanges();
                            MessageBox.Show("Müşteri başarıyla silindi!", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MusterileriListele();
                            RezervasyonlariListele();
                            ComboBoxlariDoldur();
                            MusteriAlanlariTemizle();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliMusteriID == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz müşteriyi tablodan seçiniz!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) ||
                string.IsNullOrWhiteSpace(txtMusteriSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtMusteriTelefon.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var db = new ContextDb())
                {
                    var musteri = db.Musteriler.Find(seciliMusteriID);
                    if (musteri != null)
                    {
                        musteri.Ad = txtMusteriAd.Text.Trim();
                        musteri.Soyad = txtMusteriSoyad.Text.Trim();
                        musteri.Telefon = txtMusteriTelefon.Text.Trim();
                        db.SaveChanges();
                        MessageBox.Show("Müşteri başarıyla güncellendi!", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MusterileriListele();
                        ComboBoxlariDoldur();
                        MusteriAlanlariTemizle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MusterileriListele()
        {
            try
            {
                using (var db = new ContextDb())
                {
                    var musteriListesi = db.Musteriler
                        .Select(m => new { m.MusteriID, m.Ad, m.Soyad, m.Telefon })
                        .ToList();
                    dgvMusteriler.DataSource = musteriListesi;
                    if (dgvMusteriler.Columns.Count > 0)
                    {
                        dgvMusteriler.Columns["MusteriID"].HeaderText = "Müşteri ID";
                        dgvMusteriler.Columns["Ad"].HeaderText = "Ad";
                        dgvMusteriler.Columns["Soyad"].HeaderText = "Soyad";
                        dgvMusteriler.Columns["Telefon"].HeaderText = "Telefon";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusterileriListele();
            MessageBox.Show("Müşteri listesi güncellendi!", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMusteriTemizle_Click(object sender, EventArgs e)
        {
            MusteriAlanlariTemizle();
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var satir = dgvMusteriler.Rows[e.RowIndex];
                seciliMusteriID = Convert.ToInt32(satir.Cells["MusteriID"].Value);
                txtMusteriAd.Text = satir.Cells["Ad"].Value.ToString();
                txtMusteriSoyad.Text = satir.Cells["Soyad"].Value.ToString();
                txtMusteriTelefon.Text = satir.Cells["Telefon"].Value.ToString();
            }
        }

        private void btnSahaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSahaAdi.Text) ||
                cmbSahaTuru.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtSaatlikUcret.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal ucret;
            if (!decimal.TryParse(txtSaatlikUcret.Text, out ucret))
            {
                MessageBox.Show("Ücret alanına geçerli bir sayı giriniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var db = new ContextDb())
                {
                    var yeniSaha = new Saha
                    {
                        SahaAdi = txtSahaAdi.Text.Trim(),
                        SahaTuru = cmbSahaTuru.SelectedItem.ToString(),
                        SaatlikUcret = ucret
                    };
                    db.Sahalar.Add(yeniSaha);
                    db.SaveChanges();
                    MessageBox.Show("Saha başarıyla eklendi!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SahalariListele();
                    ComboBoxlariDoldur();
                    SahaAlanlariTemizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSahaSil_Click(object sender, EventArgs e)
        {
            if (seciliSahaID == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz sahayı tablodan seçiniz!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sonuc = MessageBox.Show(
                "Bu sahayı ve ona ait tüm rezervasyonları silmek istediğinize emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    using (var db = new ContextDb())
                    {
                        var sahaRezervasyonlari = db.Rezervasyonlar
                            .Where(r => r.SahaID == seciliSahaID).ToList();
                        foreach (var rez in sahaRezervasyonlari)
                            db.Rezervasyonlar.Remove(rez);

                        var saha = db.Sahalar.Find(seciliSahaID);
                        if (saha != null)
                        {
                            db.Sahalar.Remove(saha);
                            db.SaveChanges();
                            MessageBox.Show("Saha başarıyla silindi!", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SahalariListele();
                            RezervasyonlariListele();
                            ComboBoxlariDoldur();
                            SahaAlanlariTemizle();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSahaGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliSahaID == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz sahayı tablodan seçiniz!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSahaAdi.Text) ||
                cmbSahaTuru.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtSaatlikUcret.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal ucret;
            if (!decimal.TryParse(txtSaatlikUcret.Text, out ucret))
            {
                MessageBox.Show("Ücret alanına geçerli bir sayı giriniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var db = new ContextDb())
                {
                    var saha = db.Sahalar.Find(seciliSahaID);
                    if (saha != null)
                    {
                        saha.SahaAdi = txtSahaAdi.Text.Trim();
                        saha.SahaTuru = cmbSahaTuru.SelectedItem.ToString();
                        saha.SaatlikUcret = ucret;
                        db.SaveChanges();
                        MessageBox.Show("Saha başarıyla güncellendi!", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SahalariListele();
                        ComboBoxlariDoldur();
                        SahaAlanlariTemizle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SahalariListele()
        {
            try
            {
                using (var db = new ContextDb())
                {
                    var sahaListesi = db.Sahalar
                        .Select(s => new { s.SahaID, s.SahaAdi, s.SahaTuru, s.SaatlikUcret })
                        .ToList();
                    dgvSahalar.DataSource = sahaListesi;
                    if (dgvSahalar.Columns.Count > 0)
                    {
                        dgvSahalar.Columns["SahaID"].HeaderText = "Saha ID";
                        dgvSahalar.Columns["SahaAdi"].HeaderText = "Saha Adı";
                        dgvSahalar.Columns["SahaTuru"].HeaderText = "Saha Türü";
                        dgvSahalar.Columns["SaatlikUcret"].HeaderText = "Ücret (TL)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSahaListele_Click(object sender, EventArgs e)
        {
            SahalariListele();
            MessageBox.Show("Saha listesi güncellendi!", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSahaTemizle_Click(object sender, EventArgs e)
        {
            SahaAlanlariTemizle();
        }

        private void dgvSahalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var satir = dgvSahalar.Rows[e.RowIndex];
                seciliSahaID = Convert.ToInt32(satir.Cells["SahaID"].Value);
                txtSahaAdi.Text = satir.Cells["SahaAdi"].Value.ToString();
                cmbSahaTuru.SelectedItem = satir.Cells["SahaTuru"].Value.ToString();
                txtSaatlikUcret.Text = satir.Cells["SaatlikUcret"].Value.ToString();
            }
        }

        private void btnRezervasyonEkle_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedValue == null || cmbSaha.SelectedValue == null)
            {
                MessageBox.Show("Lütfen müşteri ve saha seçiniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMacSaati.SelectedItem == null)
            {
                MessageBox.Show("Lütfen maç saatini seçiniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var db = new ContextDb())
                {
                    int sahaId = Convert.ToInt32(cmbSaha.SelectedValue);
                    DateTime seciliTarih = dtpMacTarihi.Value.Date;
                    string seciliSaat = cmbMacSaati.SelectedItem.ToString();

                    bool cakismaVar = db.Rezervasyonlar.Any(r =>
                        r.SahaID == sahaId &&
                        r.MacTarihi == seciliTarih &&
                        r.MacSaati == seciliSaat);

                    if (cakismaVar)
                    {
                        MessageBox.Show("Bu saha, seçilen tarih ve saat için zaten rezerve edilmiş!", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var yeniRezervasyon = new Rezervasyon
                    {
                        MusteriID = Convert.ToInt32(cmbMusteri.SelectedValue),
                        SahaID = sahaId,
                        MacTarihi = seciliTarih,
                        MacSaati = seciliSaat
                    };
                    db.Rezervasyonlar.Add(yeniRezervasyon);
                    db.SaveChanges();
                    MessageBox.Show("Rezervasyon başarıyla eklendi!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RezervasyonlariListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezervasyonSil_Click(object sender, EventArgs e)
        {
            if (seciliRezervasyonID == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz rezervasyonu tablodan seçiniz!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sonuc = MessageBox.Show(
                "Bu rezervasyonu silmek istediğinize emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    using (var db = new ContextDb())
                    {
                        var rezervasyon = db.Rezervasyonlar.Find(seciliRezervasyonID);
                        if (rezervasyon != null)
                        {
                            db.Rezervasyonlar.Remove(rezervasyon);
                            db.SaveChanges();
                            MessageBox.Show("Rezervasyon başarıyla silindi!", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RezervasyonlariListele();
                            seciliRezervasyonID = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RezervasyonlariListele()
        {
            try
            {
                using (var db = new ContextDb())
                {
                    var rezervasyonListesi = db.Rezervasyonlar
                        .Select(r => new
                        {
                            r.RezervasyonID,
                            MusteriAdSoyad = r.Musteri.Ad + " " + r.Musteri.Soyad,
                            SahaAdi = r.Saha.SahaAdi,
                            SahaTuru = r.Saha.SahaTuru,
                            MacTarihi = r.MacTarihi,
                            r.MacSaati,
                            SaatlikUcret = r.Saha.SaatlikUcret
                        })
                        .ToList();
                    dgvRezervasyonlar.DataSource = rezervasyonListesi;
                    if (dgvRezervasyonlar.Columns.Count > 0)
                    {
                        dgvRezervasyonlar.Columns["RezervasyonID"].HeaderText = "Rez. ID";
                        dgvRezervasyonlar.Columns["MusteriAdSoyad"].HeaderText = "Müşteri";
                        dgvRezervasyonlar.Columns["SahaAdi"].HeaderText = "Saha Adı";
                        dgvRezervasyonlar.Columns["SahaTuru"].HeaderText = "Saha Türü";
                        dgvRezervasyonlar.Columns["MacTarihi"].HeaderText = "Maç Tarihi";
                        dgvRezervasyonlar.Columns["MacTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";
                        dgvRezervasyonlar.Columns["MacSaati"].HeaderText = "Maç Saati";
                        dgvRezervasyonlar.Columns["SaatlikUcret"].HeaderText = "Ücret (TL)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezervasyonListele_Click(object sender, EventArgs e)
        {
            RezervasyonlariListele();
            MessageBox.Show("Rezervasyon listesi güncellendi!", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvRezervasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var satir = dgvRezervasyonlar.Rows[e.RowIndex];
                seciliRezervasyonID = Convert.ToInt32(satir.Cells["RezervasyonID"].Value);
            }
        }

        private void btnSorguCalistir_Click(object sender, EventArgs e)
        {
            if (rbSorgu1.Checked)
                LinqSorgu1_PahalaSahaRezervasyonlari();
            else if (rbSorgu2.Checked)
                LinqSorgu2_MusteriRezervasyonOzeti();
        }

        private void LinqSorgu1_PahalaSahaRezervasyonlari()
        {
            try
            {
                using (var db = new ContextDb())
                {
                    var sonuclar = db.Rezervasyonlar
                        .Where(r => r.Saha.SaatlikUcret > 1500)
                        .Select(r => new
                        {
                            r.RezervasyonID,
                            MusteriAdSoyad = r.Musteri.Ad + " " + r.Musteri.Soyad,
                            SahaAdi = r.Saha.SahaAdi,
                            SahaTuru = r.Saha.SahaTuru,
                            SaatlikUcret = r.Saha.SaatlikUcret,
                            r.MacTarihi,
                            r.MacSaati
                        })
                        .ToList();

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("══════════════════════════════════════════════════════");
                    sb.AppendLine("  SORGU 1: Saatlik Ücreti 1500 TL'den Fazla Olan");
                    sb.AppendLine("           Sahaların Rezervasyonları");
                    sb.AppendLine("══════════════════════════════════════════════════════");
                    sb.AppendLine();

                    if (sonuclar.Count == 0)
                    {
                        sb.AppendLine("  Sonuç bulunamadı.");
                    }
                    else
                    {
                        int sira = 1;
                        foreach (var s in sonuclar)
                        {
                            sb.AppendLine($"  {sira}. Rezervasyon (ID: {s.RezervasyonID})");
                            sb.AppendLine($"     Müşteri    : {s.MusteriAdSoyad}");
                            sb.AppendLine($"     Saha       : {s.SahaAdi} ({s.SahaTuru})");
                            sb.AppendLine($"     Ücret      : {s.SaatlikUcret:N2} TL");
                            sb.AppendLine($"     Maç Tarihi : {s.MacTarihi:dd.MM.yyyy}");
                            sb.AppendLine($"     Maç Saati  : {s.MacSaati}");
                            sb.AppendLine();
                            sira++;
                        }
                        sb.AppendLine("──────────────────────────────────────────────────────");
                        sb.AppendLine($"  Toplam {sonuclar.Count} adet rezervasyon bulundu.");
                    }
                    lblSorguSonuc.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                lblSorguSonuc.Text = "Hata oluştu: " + ex.Message;
            }
        }

        private void LinqSorgu2_MusteriRezervasyonOzeti()
        {
            try
            {
                using (var db = new ContextDb())
                {
                    var sonuclar = db.Musteriler
                        .Select(m => new
                        {
                            MusteriAdSoyad = m.Ad + " " + m.Soyad,
                            m.Telefon,
                            RezervasyonSayisi = m.Rezervasyonlar.Count,
                            ToplamTutar = m.Rezervasyonlar
                                .Select(r => r.Saha.SaatlikUcret)
                                .DefaultIfEmpty(0)
                                .Sum()
                        })
                        .ToList();

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("══════════════════════════════════════════════════════");
                    sb.AppendLine("  SORGU 2: Müşteri Rezervasyon Özeti");
                    sb.AppendLine("══════════════════════════════════════════════════════");
                    sb.AppendLine();

                    if (sonuclar.Count == 0)
                    {
                        sb.AppendLine("  Kayıtlı müşteri bulunamadı.");
                    }
                    else
                    {
                        int sira = 1;
                        foreach (var s in sonuclar)
                        {
                            sb.AppendLine($"  {sira}. {s.MusteriAdSoyad}");
                            sb.AppendLine($"     Telefon             : {s.Telefon}");
                            sb.AppendLine($"     Rezervasyon Sayısı  : {s.RezervasyonSayisi}");
                            sb.AppendLine($"     Toplam Harcama      : {s.ToplamTutar:N2} TL");
                            sb.AppendLine();
                            sira++;
                        }
                        sb.AppendLine("──────────────────────────────────────────────────────");
                        sb.AppendLine($"  Toplam {sonuclar.Count} müşteri listelendi.");
                        sb.AppendLine($"  Genel Toplam Harcama: {sonuclar.Sum(s => s.ToplamTutar):N2} TL");
                    }
                    lblSorguSonuc.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                lblSorguSonuc.Text = "Hata oluştu: " + ex.Message;
            }
        }
    }
}
