using Microsoft.AspNetCore.Mvc;

namespace EldenRing.Mvc.App.Web.Controllers
{
    public class ArmorController : Controller
    {
        private IBase _Base;

        public ArmorController(IBase iBase)
        {
            _Base = iBase;
        }

        public IActionResult Index()
        {
            var armor=_Base.FetchArmors();
            ViewBag.list = armor;
            return View();
        }
    }
}
