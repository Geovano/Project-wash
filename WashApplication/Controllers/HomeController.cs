using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WashApplication.Context;
using WashApplication.Models;

namespace WashApplication.Controllers
{
    public class HomeController : Controller
    {
        private AcessoContext db = new AcessoContext();

        public ActionResult CreateLavagem()
        {
            ViewBag.ServicoID = new SelectList(db.servico, "iD", "Nome");
            return View();
        }

        public ActionResult CreateUsuario()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}