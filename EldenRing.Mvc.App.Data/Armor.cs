namespace EldenRing.Mvc.App.Data;

public class Armor
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public string description { get; set; }
    public string category { get; set; }
    public ICollection<DmgNegation> dmgNegation { get; set; }
    public ICollection<Resistance> resistance { get; set; }
    public double weight { get; set; }
}