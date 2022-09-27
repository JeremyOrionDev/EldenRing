namespace EldenRing.Mvc.App.Data;

public class Weapon
{
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string image { get; set; }
    public string category { get; set; }
    public double weight { get; set; }
    public virtual ICollection< Attack> attack { get; set; }
    public virtual ICollection<Defence> defence { get; set; }
    public virtual ICollection<RequiredAttribute> requiredAttributes { get; set; }
    public virtual ICollection<ScalesWith> scalesWith { get; set; }

}