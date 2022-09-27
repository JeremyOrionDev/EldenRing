namespace EldenRing.Mvc.App.Data;

public class Attack
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string name { get; set; }
    public double amount { get; set; }
    public virtual Weapon Weapon { get; set; }
}