namespace EldenRing.Mvc.App.Data;

public class Classes
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public virtual ICollection<Stats> stats { get; set; }
}