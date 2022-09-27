using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenRing.Mvc.App.Business.Interfaces
{
    public interface IBase
    {
        ICollection<Armor> FetchArmors();
    }
}
