using Microsoft.AspNetCore.Mvc;
using SistemaContratos.Models;

namespace SistemaContratos.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            List<AreaViewModel> listadoAreas = new List<AreaViewModel>();

            return View(listadoAreas);
        }

        public IActionResult AltaArea()
        {
            var areaVm = new AreaViewModel();
            return View(areaVm);
        }

        public IActionResult GuardarArea(AreaViewModel areaVm)
        {
            return Redirect(nameof(Index));
            //return View("Index");
        }
    }
}
