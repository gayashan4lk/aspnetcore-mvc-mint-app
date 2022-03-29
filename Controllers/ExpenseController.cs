﻿using Microsoft.AspNetCore.Http;
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

        public IActionResult Index()
        {
            IEnumerable<Expense> expensesList = _db.Expenses;
            return View(expensesList);
        }
       
    }
}
