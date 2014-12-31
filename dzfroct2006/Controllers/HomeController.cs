using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using dzfroct2006.DAL;
using dzfroct2006.Models;

namespace dzfroct2006.Controllers
{
    
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            HotelsDBContext context = new HotelsDBContext();

            var hotel = new Hotels() { Name = "TestHotel", Description="Un simple hotel de test", FaxNumber1="0021321659878" };

            context.Hotels.Add(hotel);

            context.SaveChanges();

            var Hotels = context.Hotels;
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChangeLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;

            Session["lang"] = culture;
            HttpCookie languageCookie = new HttpCookie("languageCookie");
            languageCookie["lang"] = culture;
            Response.Cookies.Add(languageCookie);
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}
