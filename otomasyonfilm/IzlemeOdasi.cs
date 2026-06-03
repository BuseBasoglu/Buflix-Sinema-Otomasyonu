using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otomasyonfilm
{
    [Table("Table_IzlemeOdasi")]
    public class IzlemeOdasi
    {
        [Key]
        public int Oda_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string OdaAdi { get; set; }

        public DateTime IzlemeTarihi { get; set; }

        [ForeignKey("KurucuKullanici")]
        public int Kurucu_Id { get; set; }

        [ForeignKey("Film")]
        public int Film_Id { get; set; }

        public virtual Kullanici KurucuKullanici { get; set; }
        public virtual Film Film { get; set; }
        public virtual ICollection<OdaMesaj> Mesajlar { get; set; }
    }
}