using Microsoft.AspNetCore.Mvc;
using Mint.Data;
using Mint.Models;
using System.Collections.Generic;

namespace Mint.Controllers
{
    public class ItemController : Controller
    {
        private readonly MintDbContext _db;

        public ItemController(MintDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> ObjList = _db.Items;
            return View(ObjList);
        }

        // GET - Create()
        public IActionResult Create()
        {
            return View();
        }

        // POST - Create()
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
