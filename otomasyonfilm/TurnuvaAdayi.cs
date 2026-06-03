using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otomasyonfilm
{
    [Table("Table_TurnuvaAdayi")]
    public class TurnuvaAdayi
    {
        [Key]
        public int Aday_Id { get; set; }

        [ForeignKey("Film")]
        public int Film_Id { get; set; }

        public int OySayisi { get; set; } = 0;

        public virtual Film Film { get; set; }
    }
}