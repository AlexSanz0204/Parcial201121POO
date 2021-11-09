using AplicacionWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWeb.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult PersonaVista() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult PersonaVista(Usuario p)
        {
            Console.WriteLine(p.Usuario);

            return View();
        }
        [HttpGet]
        public ActionResult ClaseHtml() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult ClaseHtml(Usuario p)
        {
            _ = p;
            if (p.Usuario.Equals("Alexander") && p.Contraseña.Equals("020418")) 
            {
                return Redirect("Bienvenido");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Bienvenida() 
        {
            return View();
        }
    }
}