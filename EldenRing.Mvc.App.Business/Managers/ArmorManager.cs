namespace EldenRing.Mvc.App.Business.Managers;

public class ArmorManager : IArmor
{
    public Armor GetArmor(string id)
    {
        Armor armor = JsonConvert.DeserializeObject<Armor>(File.ReadAllText("Files/Armors.json"));
        return armor;
    }

    public List<Armor> GetArmorList()
    {
        throw new NotImplementedException();
    }
}
