using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otomasyonfilm
{
    [Table("Table_IzlemeListesi")]
    public class IzlemeListesi
    {
        [Key]
        public int Kayit_Id { get; set; }

        [ForeignKey("Kullanici")]
        public int Kullanici_Id { get; set; }

        [ForeignKey("Film")]
        public int Film_Id { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Film Film { get; set; }
    }
}