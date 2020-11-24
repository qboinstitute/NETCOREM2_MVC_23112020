using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETCOREM2_MVC.Models;

namespace NETCOREM2_MVC.Controllers
{
    public class SeguridadController : Controller
    {
        [Route("/Seguridad/Index")]
        [Route("Security")]
        [Route("sec/index")]
        public IActionResult Index()
        {
            return View();
        }


        //public IActionResult Login(string Correo, string Clave)
        //public IActionResult Login(Usuario usuario)
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            string correo = form["Correo"];
            string clave = form["Clave"];

            if (correo.Equals("lchang@qbo.com") && clave.Equals("123456"))
                return RedirectToAction("Index", "Home");
            else
                return RedirectToAction("Index");            
        }


    }
}
