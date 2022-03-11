using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _09032022_OtomatikMigrations.Models
{
    [Table("Yazar")]
    public class Yazar
    {
        [Key]
        public int ID { get; set; }

        [StringLength(20),Required]
        public String isim { get; set; }

        [StringLength(20), Required]
        public string Soyisim { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}