using Leginfor.Models;
using Leginfor.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leginfor.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Productos()
        {
            return View();
        }
        public ActionResult Suscribirse()
        {
            return View();
        }
        public ActionResult Nosotros()
        {
            return View();
        }
        public ActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contactanos(Contacto cont)
        {
            Mail mail = new Mail();
            mail.Asunto = cont.Asunto;
            mail.Destinatarios.Add(cont.Email);
            mail.Cuerpo = cont.Mensaje;
            if (Correos.Enviar(mail))
            {
                ViewBag.Respuesta = "Correo Enviado";
            }else
            {
                ViewBag.Respuesta = "Ocurrio un error al enviar";
            }
            return View();
        }
    }
}