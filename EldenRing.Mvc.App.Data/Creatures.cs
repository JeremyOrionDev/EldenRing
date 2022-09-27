namespace EldenRing.Mvc.App.Data;

public class Creatures
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public string description { get; set; }
    public string location { get; set; }
    public ICollection<Drop> drops { get; set; }
}