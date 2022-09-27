namespace EldenRing.Mvc.App.Data;

public class AttackPower
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string name { get; set; }
    public double amount { get; set; }

    public virtual Ammos Ammos { get; set; }
}