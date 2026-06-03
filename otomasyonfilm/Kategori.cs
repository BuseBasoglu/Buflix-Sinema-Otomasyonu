using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otomasyonfilm
{
    [Table("Table_Kategori")]
    public class Kategori
    {
        [Key]
        public int Kategori_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string KategoriAdi { get; set; }

        public virtual ICollection<Film> Filmler { get; set; }
    }
}