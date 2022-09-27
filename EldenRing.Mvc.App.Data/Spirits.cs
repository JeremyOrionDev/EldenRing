namespace EldenRing.Mvc.App.Data;

public class Spirits
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public string description { get; set; }
    public double fpCots { get; set; }
    public double hpCost { get; set; }
    public string effects { get; set; }
}