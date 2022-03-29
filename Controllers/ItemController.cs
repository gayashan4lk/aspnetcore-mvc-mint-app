using Microsoft.AspNetCore.Mvc;

namespace Mint.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
