using Microsoft.AspNetCore.Mvc;

namespace SistemaContratos.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
