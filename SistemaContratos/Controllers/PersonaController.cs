using Microsoft.AspNetCore.Mvc;

namespace SistemaContratos.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
