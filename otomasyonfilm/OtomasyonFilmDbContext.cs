using System.Data.Entity;

namespace otomasyonfilm
{
    public class OtomasyonFilmDbContext : DbContext
    {
        public OtomasyonFilmDbContext() : base("name=otomasyonfilm")
        {
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<IzlemeListesi> IzlemeListeleri { get; set; }
        public DbSet<Inceleme> Incelemeler { get; set; }
        public DbSet<TurnuvaAdayi> TurnuvaAdaylari { get; set; }
        public DbSet<IzlemeOdasi> IzlemeOdalari { get; set; }
        public DbSet<OdaMesaj> OdaMesajlari { get; set; }
    }
}