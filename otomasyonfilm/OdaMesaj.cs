using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otomasyonfilm
{
    [Table("Table_OdaMesaj")]
    public class OdaMesaj
    {
        [Key]
        public int Mesaj_Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string MesajMetni { get; set; }

        public DateTime GonderimZamani { get; set; } = DateTime.Now;

        [ForeignKey("Oda")]
        public int Oda_Id { get; set; }

        [ForeignKey("GonderenKullanici")]
        public int Kullanici_Id { get; set; }

        public virtual IzlemeOdasi Oda { get; set; }
        public virtual Kullanici GonderenKullanici { get; set; }
    }
}