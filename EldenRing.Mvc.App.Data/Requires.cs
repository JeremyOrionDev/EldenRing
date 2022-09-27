namespace EldenRing.Mvc.App.Data;

public class Requires
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string name { get; set; }
    public double amount { get; set; }
    public virtual Sorceries Sorceries { get; set; }
}