namespace EldenRing.Mvc.App.Data;

public class Ammos
{
    public Ammos()
    {
        attackPower =  new HashSet<AttackPower>();
    }

    public Ammos(string id, string name, string description, string image, string type, string passive, ICollection<AttackPower> attackPower)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.image = image;
        this.type = type;
        this.passive = passive;
        this.attackPower = attackPower;
    }

    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string image { get; set; }
    public string type { get; set; }
    public string passive { get; set; }
    public ICollection<AttackPower> attackPower { get; set; }
}