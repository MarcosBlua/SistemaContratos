﻿using Microsoft.AspNetCore.Mvc;

namespace SistemaContratos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
