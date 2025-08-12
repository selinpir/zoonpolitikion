using Microsoft.AspNetCore.Mvc;

namespace StatikWebMvc.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
