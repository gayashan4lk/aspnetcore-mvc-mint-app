using Microsoft.AspNetCore.Mvc;
using Mint.Data;
using System.Collections.Generic;
using Mint.Models;

namespace Mint.Controllers
{
    public class ExpenseCategoryController : Controller
    {
        private readonly MintDbContext _db;
        public ExpenseCategoryController(MintDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ExpenseCategory> expenseCategoryList = _db.ExpenseCategories;
            return View(expenseCategoryList);
        }
        
        // GET create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseCategory expenseCategory)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseCategories.Add(expenseCategory);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expenseCategory);
        }
    }
}
