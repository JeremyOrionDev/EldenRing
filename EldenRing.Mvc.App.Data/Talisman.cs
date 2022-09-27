namespace EldenRing.Mvc.App.Data;

public class Talisman
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string effects { get; set; }

}