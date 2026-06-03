using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otomasyonfilm
{
    [Table("Table_Kullanici")]
    public class Kullanici
    {
        [Key]
        public int Kullanici_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ad { get; set; }

        [Required]
        [MaxLength(50)]
        public string Soyad { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Telefon { get; set; }

        public int ElestirmenPuani { get; set; } = 0;

        [MaxLength(50)]
        public string Rutbe { get; set; } = "Acemi İzleyici";

        public virtual ICollection<IzlemeListesi> IzlemeListeleri { get; set; }
        public virtual ICollection<Inceleme> Incelemeler { get; set; }
        public virtual ICollection<IzlemeOdasi> KurduguOdalar { get; set; }
        public virtual ICollection<OdaMesaj> GonderdigiMesajlar { get; set; }
    }
}