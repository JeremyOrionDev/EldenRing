namespace EldenRing.Mvc.App.Data;

public class Sorceries
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public string description { get; set; }
    public string type { get; set; }
    public double cost { get; set; }
    public double slots { get; set; }
    public string effects { get; set; }
    public virtual ICollection<Requires> requires { get; set; }
}