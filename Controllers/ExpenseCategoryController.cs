using Microsoft.AspNetCore.Mvc;

namespace Mint.Controllers
{
    public class ExpenseCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
