namespace EldenRing.Mvc.App.Data;

public class DmgNegation
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string name { get; set; }
    public double amount { get; set; }
    public virtual Armor Armor { get; set; }
}