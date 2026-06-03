using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace otomasyonfilm
{
    [Table("Table_Film")]
    
        
        public class Film
        {
            [Key]
            public int Film_Id { get; set; }

            [Required]
            [MaxLength(50)]
            public string FilmAdi { get; set; }

            [Required]
            
            [ForeignKey("Kategori")] 
            public int Kategori_Id { get; set; }

            public virtual Kategori Kategori { get; set; }

            public virtual ICollection<IzlemeListesi> IzlemeListeleri { get; set; }
            public virtual ICollection<Inceleme> Incelemeler { get; set; }
            public virtual ICollection<TurnuvaAdayi> TurnuvaAdaylari { get; set; }
        [MaxLength(50)]
        public string Mood { get; set; } = "Belirtilmedi";
    }
    
}
