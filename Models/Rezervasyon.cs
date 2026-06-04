using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliSahaRezervasyonOtomasyonu.Models
{

    [Table("Rezervasyonlar")]
    public class Rezervasyon
    {

        [Key]
        public int RezervasyonID { get; set; }

        public int MusteriID { get; set; }

        public int SahaID { get; set; }

        [Required]
        public DateTime MacTarihi { get; set; }

        [Required]
        [StringLength(10)]
        public string MacSaati { get; set; }

        [ForeignKey("MusteriID")]
        public virtual Musteri Musteri { get; set; }

        [ForeignKey("SahaID")]
        public virtual Saha Saha { get; set; }
    }
}
