using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaNet.Models;


namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Incluir()
        {
            var cli = new Cliente();
            return View(cli);
        }

        [HttpPost]
        public ActionResult Incluir(Cliente cliente)
        {

        }
        
        public ActionResult Index()
        {
            return View();
        }
    }
}