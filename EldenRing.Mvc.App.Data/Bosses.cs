namespace EldenRing.Mvc.App.Data;

public class Bosses
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public string description { get; set; }
    public string location { get; set; }
    public virtual ICollection<Drop> drops { get; set; }
    public string healthPoints { get; set; }
}