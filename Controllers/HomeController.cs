using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETCOREM2_MVC.Models;

namespace NETCOREM2_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Mensaje = "Bienvenido al Curso";
            List<Producto> productos = new List<Producto>();
            Producto prod1 = new Producto();
            prod1.Id = 1;
            prod1.Descripcion = "Televisor UHD";
            prod1.Precio = 3300;

            Producto prod2 = new Producto();
            prod2.Id = 2;
            prod2.Descripcion = "Play Station 5";
            prod2.Precio = 3000;

            productos.Add(prod1);
            productos.Add(prod2);

            ViewBag.ListaProducto = productos;

            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult Products()
        {
            return View();
            //return View("Privacy");
            //return RedirectToAction("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
