namespace EldenRing.Mvc.App.Data;

public class Items
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string type { get; set; }
    public string effect { get; set; }
}