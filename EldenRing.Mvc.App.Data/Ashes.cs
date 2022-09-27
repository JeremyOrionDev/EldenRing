namespace EldenRing.Mvc.App.Data;

public class Ashes
{
    [Key]
    public string id { get; set; }

    public string name { get; set; }
    public string image { get; set; }
    public string description { get; set; }
    public string affinity { get; set; }
    public string skill { get; set; }
}