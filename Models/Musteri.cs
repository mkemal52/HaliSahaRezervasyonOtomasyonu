using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliSahaRezervasyonOtomasyonu.Models
{

    [Table("Musteriler")]
    public class Musteri
    {

        [Key]
        public int MusteriID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefon { get; set; }

        public virtual ICollection<Rezervasyon> Rezervasyonlar { get; set; }

        public Musteri()
        {
            Rezervasyonlar = new HashSet<Rezervasyon>();
        }
    }
}
