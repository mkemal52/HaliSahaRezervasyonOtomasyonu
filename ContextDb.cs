using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaliSahaRezervasyonOtomasyonu.Models;

namespace HaliSahaRezervasyonOtomasyonu
{

    public class ContextDb : DbContext
    {

        public ContextDb() : base("name=HaliSahaDB")
        {

        }

        public DbSet<Musteri> Musteriler { get; set; }

        public DbSet<Saha> Sahalar { get; set; }

        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
    }
}
