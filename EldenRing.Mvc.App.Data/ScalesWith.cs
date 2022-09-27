namespace EldenRing.Mvc.App.Data;

public class ScalesWith
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string name { get; set; }
    public string scaling { get; set; }
}