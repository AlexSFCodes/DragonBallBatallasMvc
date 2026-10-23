using System.Web.Mvc;

namespace DragonBallBatallasMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Registro de Batallas MVC con EF y Scaffold";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto";
            return View();
        }
    }
}