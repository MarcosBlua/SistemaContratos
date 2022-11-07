using Microsoft.AspNetCore.Mvc;

namespace SistemaContratos.Controllers
{
    public class ContratoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
