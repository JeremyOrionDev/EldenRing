namespace EldenRing.Mvc.App.Data;

public class Resistance
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string name { get; set; }
    public int amount { get; set; }
    public virtual Armor Armor { get; set; }
}