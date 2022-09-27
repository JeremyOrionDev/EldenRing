namespace EldenRing.Mvc.App.Data;

public class Drop
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string drops { get; set; }
    public virtual Bosses Bosses { get; set; }
    public virtual Creatures Creatures { get; set; }
}