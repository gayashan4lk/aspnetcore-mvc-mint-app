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

        // POST create
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

        // POST delete
        public IActionResult Delete(int? id)
        {
            if(id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            if(id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.ExpenseCategories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET update
        public IActionResult Update(int? id)
        {
            if(id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpenseCategory expenseCategory)
        {
            if(expenseCategory == null)
            {
                return NotFound();
            }
            _db.ExpenseCategories.Update(expenseCategory);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
