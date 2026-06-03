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
    /// Saha sınıfı - Müstakil (Bağımsız) Tablo
    /// Veritabanındaki "Sahalar" tablosuna karşılık gelir.
    /// Bir sahanın birden fazla rezervasyonu olabilir (One-to-Many ilişki).
    /// </summary>
    [Table("Sahalar")]
    public class Saha
    {
        // ===== PRİMARY KEY (Birincil Anahtar) =====
        // Veritabanındaki SahaID kolonuna karşılık gelir.
        [Key]
        public int SahaID { get; set; }

        // ===== KOLONLAR =====

        [Required]
        [StringLength(100)]
        public string SahaAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string SahaTuru { get; set; }

        // decimal tipi parasal değerler için kullanılır.
        // Hassas hesaplamalar yapabilir (float/double'a göre daha güvenilir).
        [Required]
        public decimal SaatlikUcret { get; set; }

        // ===== NAVİGATİON PROPERTY (Gezinme Özelliği) =====
        // Bir sahanın birden fazla rezervasyonu olabilir.
        // Bu ilişki "One-to-Many" (Bire-Çok) ilişkidir.
        // "virtual" anahtar kelimesi Lazy Loading için gereklidir.
        public virtual ICollection<Rezervasyon> Rezervasyonlar { get; set; }

        // ===== YAPICI METOT (Constructor) =====
        public Saha()
        {
            Rezervasyonlar = new HashSet<Rezervasyon>();
        }
    }
}
