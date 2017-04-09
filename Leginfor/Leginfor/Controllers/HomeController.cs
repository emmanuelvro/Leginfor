using Leginfor.Models;
using Leginfor.Models.Index;
using Leginfor.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Leginfor.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            string prueba = Utility.Utility.Code("Qpalzm1092", false,false);
            var externalIdentity = HttpContext.GetOwinContext().Authentication.GetExternalIdentityAsync(DefaultAuthenticationTypes.ExternalCookie);
            var email = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;
            var firstName = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == "urn:facebook:first_name").Value;
            var lastName = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == "urn:facebook:last_name").Value;
            Index ind = new Index();
            ind.Dof = DofModel.getDof(DateTime.Now);
            ind.Rss = Utility.Utility.getRssFeed();
            ind.ReformasFed = DofModel.getRefFederales();
            ind.lstIndicadores = IndicadoresModel.getIndicadoresUltimos();
            ind.lstRelevantesDof = DofModel.getRelevantes(1);
            ind.lstRelGaceta = DofModel.getRelevantes(2);
            ind.lstRelFiscal = DofModel.getRelevantes(5);
            return View(ind);
        }

        [HttpPost]
        public ActionResult Index(string fechaCal)
        {
            return View();
        }
         
        [HttpPost]
        public ActionResult Index(Usuario usr)
        {
           return View(usr);
        }
        
    }
}