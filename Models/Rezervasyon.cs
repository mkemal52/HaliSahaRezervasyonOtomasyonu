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
    /// Rezervasyon sınıfı - Aracı (İlişkisel) Tablo
    /// Veritabanındaki "Rezervasyonlar" tablosuna karşılık gelir.
    /// Musteriler ve Sahalar tablolarını birbirine bağlar.
    /// Her rezervasyon bir müşteriye ve bir sahaya aittir (Many-to-One ilişki).
    /// </summary>
    [Table("Rezervasyonlar")]
    public class Rezervasyon
    {
        // ===== PRİMARY KEY (Birincil Anahtar) =====
        [Key]
        public int RezervasyonID { get; set; }

        // ===== FOREİGN KEY'LER (Yabancı Anahtarlar) =====
        // Bu alanlar, Rezervasyon tablosunu diğer tablolara bağlar.
        // Veritabanında FK (Foreign Key) kısıtlaması oluşturur.

        // Müşteri ile ilişki - Hangi müşterinin rezervasyonu olduğunu belirtir
        public int MusteriID { get; set; }

        // Saha ile ilişki - Hangi sahada oynandığını belirtir
        public int SahaID { get; set; }

        // ===== KOLONLAR =====

        [Required]
        public DateTime MacTarihi { get; set; }

        [Required]
        [StringLength(10)]
        public string MacSaati { get; set; }

        // ===== NAVİGATİON PROPERTY'LER (Gezinme Özellikleri) =====
        // [ForeignKey("MusteriID")] -> Bu navigation property'nin hangi FK ile
        // ilişkili olduğunu belirtir. EF6 bu sayede JOIN sorgularını otomatik oluşturur.
        // "virtual" -> Lazy Loading desteği sağlar.

        // Her rezervasyon BİR müşteriye aittir (Many-to-One)
        [ForeignKey("MusteriID")]
        public virtual Musteri Musteri { get; set; }

        // Her rezervasyon BİR sahada yapılır (Many-to-One)
        [ForeignKey("SahaID")]
        public virtual Saha Saha { get; set; }
    }
}
