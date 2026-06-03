using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otomasyonfilm
{
    [Table("Table_Inceleme")]
    public class Inceleme
    {
        [Key]
        public int Inceleme_Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string YorumMetni { get; set; }

        public int FaydaliSayisi { get; set; } = 0;

        [ForeignKey("Kullanici")]
        public int Kullanici_Id { get; set; }

        [ForeignKey("Film")]
        public int Film_Id { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Film Film { get; set; }
    }
}