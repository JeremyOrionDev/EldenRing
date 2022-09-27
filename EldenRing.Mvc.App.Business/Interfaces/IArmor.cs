namespace EldenRing.Mvc.App.Business.Interfaces;

public interface IArmor
{
    Armor GetArmor(string id);
    List<Armor> GetArmorList();
}
