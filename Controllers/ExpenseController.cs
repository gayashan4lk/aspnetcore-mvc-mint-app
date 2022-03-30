using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mint.Data;
using Mint.Models;
using System.Collections.Generic;

namespace Mint.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly MintDbContext _db;
        public ExpenseController(MintDbContext db)
        {
            _db = db;
        }

        // Index
        public IActionResult Index()
        {
            IEnumerable<Expense> expensesList = _db.Expenses;
            return View(expensesList);
        }

        // GET Create()
        public IActionResult Create()
        {
            return View();
        }

        // POST Create()
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                _db.Expenses.Add(expense);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }

        // POST Delete()
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Expenses.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Expenses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET Delete()
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Expenses.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}
