namespace EldenRing.Mvc.App.Data;

public class Stats
{
    [Key]
    public string level { get; set; }
    public string vigor { get; set; }
    public string mind { get; set; }
    public string endurance { get; set; }
    public string strength { get; set; }
    public string dexterity { get; set; }
    public string intelligence { get; set; }
    public string faith { get; set; }
    public string arcane { get; set; }

    public virtual Classes Classes { get; set; }
}