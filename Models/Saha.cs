using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliSahaRezervasyonOtomasyonu.Models
{

    [Table("Sahalar")]
    public class Saha
    {

        [Key]
        public int SahaID { get; set; }

        [Required]
        [StringLength(100)]
        public string SahaAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string SahaTuru { get; set; }

        [Required]
        public decimal SaatlikUcret { get; set; }

        public virtual ICollection<Rezervasyon> Rezervasyonlar { get; set; }

        public Saha()
        {
            Rezervasyonlar = new HashSet<Rezervasyon>();
        }
    }
}
