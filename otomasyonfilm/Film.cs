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
            
            [ForeignKey("Kategori")] // Filmin hangi kategoriye ait olduğunu (Foreign Key) bildiriyoruz[cite: 3].
            public int Kategori_Id { get; set; }

            // Bu film tek bir kategoriye aittir diyoruz (Sanal bağlantı köprüsü)[cite: 3].
            public virtual Kategori Kategori { get; set; }

            // Bu filmin birden fazla izleme listesinde kaydı olabilir diyoruz[cite: 3].
            public virtual ICollection<IzlemeListesi> IzlemeListeleri { get; set; }
            public virtual ICollection<Inceleme> Incelemeler { get; set; }
        // Bir film turnuvaya aday gösterilebilir
            public virtual ICollection<TurnuvaAdayi> TurnuvaAdaylari { get; set; }
        // Filmin hitap ettiği ruh hali (Örn: "Kafa Dağıtmalık", "Ters Köşe Yapan")
        [MaxLength(50)]
        public string Mood { get; set; } = "Belirtilmedi";
    }
    
}
