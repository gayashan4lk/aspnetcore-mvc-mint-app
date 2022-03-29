using Microsoft.AspNetCore.Mvc;
using System;

namespace Mint.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            /*string todaysDate = DateTime.Now.ToShortDateString();
            return Ok(todaysDate);*/
        }
    }
}
