namespace EldenRing.Mvc.App.Business.Managers;

public class BaseManager:IBase
{
    private readonly DataContext _context;

    public BaseManager(DataContext context)
    {
        _context = context;
    }
    ICollection<Armor> IBase.FetchArmors()
    {
        /*string dire = AppDomain.CurrentDomain.BaseDirectory;
        string texte = File.ReadAllText(dire + "\\Files\\armors.json");
        var r=JsonConvert.DeserializeObject<List<Armor>>(texte);
        using (IDbContextTransaction _trx=_context.Database.BeginTransaction())
        {
            foreach (Armor item in r)
            {
                Armor a = item;
                if (item.image==null || item.image.Length==0)
                {
                    a.image = "https://thumbs.dreamstime.com/b/404-error-page-not-found-design-29506876.jpg";
                }
                if (item.description==null || item.description.Length==0)
                {
                    a.description = "null";
                }
                _context.Armor.Add(a);

            }
            if (_context.SaveChanges()>0)
            {
                _trx.Commit();
            }else { _trx.Rollback(); }
        }*/
        return _context.Armor.ToList();
    }
}
