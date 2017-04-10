using BotDetect.Web.Mvc;
using Leginfor.Models.About;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leginfor.Controllers
{
    public class AboutController : Controller
    {
        // GET: Contacto
        public ActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        [CaptchaValidation("CaptchaCode", "Captcha", "Incorrect CAPTCHA code!")]
        public ActionResult Contacto(Contacto cont)
        {
            bool prueba = MvcCaptcha.Validate("CaptchaCode", "Captcha", "Incorrect CAPTCHA code!");
                MvcCaptcha.ResetCaptcha("Captcha");
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
    }
}