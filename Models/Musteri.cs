using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliSahaRezervasyonOtomasyonu.Models
{
    /// <summary>
    /// Müşteri sınıfı - Müstakil (Bağımsız) Tablo
    /// Veritabanındaki "Musteriler" tablosuna karşılık gelir.
    /// Bir müşterinin birden fazla rezervasyonu olabilir (One-to-Many ilişki).
    /// </summary>
    [Table("Musteriler")]
    public class Musteri
    {
        // ===== PRİMARY KEY (Birincil Anahtar) =====
        // Veritabanındaki MusteriID kolonuna karşılık gelir.
        // [Key] attribute'u bu özelliğin birincil anahtar olduğunu belirtir.
        [Key]
        public int MusteriID { get; set; }

        // ===== KOLONLAR =====
        // [Required] -> Bu alanın boş bırakılamayacağını belirtir (NOT NULL).
        // [StringLength(50)] -> Maksimum karakter uzunluğunu belirtir.

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefon { get; set; }

        // ===== NAVİGATİON PROPERTY (Gezinme Özelliği) =====
        // Bir müşterinin birden fazla rezervasyonu olabilir.
        // Bu ilişki "One-to-Many" (Bire-Çok) ilişkidir.
        // "virtual" anahtar kelimesi Lazy Loading (tembel yükleme) için gereklidir.
        // ICollection<Rezervasyon> -> Bu müşteriye ait tüm rezervasyonların listesi.
        public virtual ICollection<Rezervasyon> Rezervasyonlar { get; set; }

        // ===== YAPICI METOT (Constructor) =====
        // Koleksiyonu başlatmak için yapıcı metot kullanılır.
        // Bu sayede null referans hatası önlenir.
        public Musteri()
        {
            Rezervasyonlar = new HashSet<Rezervasyon>();
        }
    }
}
