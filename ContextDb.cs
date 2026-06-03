using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaliSahaRezervasyonOtomasyonu.Models;

namespace HaliSahaRezervasyonOtomasyonu
{
    /// <summary>
    /// ContextDb - Ana veritabanı bağlam sınıfı
    /// System.Data.Entity.DbContext sınıfından miras alır (EF6).
    /// Bu sınıf, C# kodları ile MSSQL veritabanı arasındaki köprüdür.
    /// İçindeki DbSet'ler, veritabanındaki tablolara karşılık gelir.
    /// </summary>
    public class ContextDb : DbContext
    {
        // ===== YAPICI METOT (Constructor) =====
        // base("name=HaliSahaDB") -> Kesinlikle App.config'deki connection string'i kullanmaya zorlar.
        // Bu sayede SSMS'teki asıl veritabanınıza bağlanır.
        public ContextDb() : base("name=HaliSahaDB")
        {

        }

        // ===== DbSet TANİMLARI =====
        // Her DbSet<T>, veritabanındaki bir tabloya karşılık gelir.
        // DbSet üzerinden CRUD (Ekle, Oku, Güncelle, Sil) işlemleri yapılır.

        /// <summary>
        /// Musteriler tablosuna erişim sağlar.
        /// Örnek kullanım: db.Musteriler.Add(yeniMusteri);
        /// </summary>
        public DbSet<Musteri> Musteriler { get; set; }

        /// <summary>
        /// Sahalar tablosuna erişim sağlar.
        /// Örnek kullanım: db.Sahalar.ToList();
        /// </summary>
        public DbSet<Saha> Sahalar { get; set; }

        /// <summary>
        /// Rezervasyonlar tablosuna erişim sağlar.
        /// Örnek kullanım: db.Rezervasyonlar.Where(r => r.SahaID == 1);
        /// </summary>
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
    }
}
