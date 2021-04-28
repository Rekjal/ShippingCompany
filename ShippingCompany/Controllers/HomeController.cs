using Microsoft.AspNetCore.Mvc;

namespace ShippingCompany.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }

}