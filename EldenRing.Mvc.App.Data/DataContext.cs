namespace EldenRing.Mvc.App.Data;

public class DataContext : DbContext
{
    protected readonly IConfiguration _config;

    public DataContext(DbContextOptions<DataContext> options) :base(options){ }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {

        if (!optionsBuilder.IsConfigured)

        {

            optionsBuilder.UseSqlServer(_config.GetConnectionString("Default"));

        }

    }

    public virtual DbSet<Armor> Armor { get; set; }
    public virtual DbSet<Ammos> Ammos { get; set; }
    public virtual DbSet<Ashes> Ashes { get; set; }
    public virtual DbSet<Bosses> Bosses { get; set; }
    public virtual DbSet<Classes> Classes { get; set; }
    public virtual DbSet<Creatures> Creatures { get; set; }
    public virtual DbSet<Incantations> Incantations { get; set; }
    public virtual DbSet<Items> Items { get; set; }
    public virtual DbSet<Locations> Locations { get; set; }
    public virtual DbSet<NPCs> NPCs { get; set; }
    public virtual DbSet<Shield> Shields { get; set; }
    public virtual DbSet<Sorceries> Sorceries { get; set; }
    public virtual DbSet<Spirits> Spirits { get; set; }
    public virtual DbSet<Talisman> Talismans { get; set; }
    public virtual DbSet<Weapon> Weapons { get; set; }


}